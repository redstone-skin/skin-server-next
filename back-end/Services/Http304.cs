using System.Net;
using System.Text;
using System.Security.Cryptography;
using Microsoft.Extensions.Primitives;

namespace SkinServerNext.Services;
public class Http304 : IHttp304 {
	private readonly HttpRequest Request;
	private readonly HttpResponse Response;
	private readonly ILogger<Http304> _logger;
	private readonly IHttpConnectionInfo _connection;
	private static readonly string _lastModified = File.GetLastWriteTime(System.Reflection.Assembly.GetExecutingAssembly().Location).ToUniversalTime().ToString("R");

	public Http304(IHttpContextAccessor accessor, IHttpConnectionInfo connection, ILogger<Http304> logger) {
		Request = accessor.HttpContext!.Request;
		Response = accessor.HttpContext.Response;
		_connection = connection;
		_logger = logger;
	}

	/// <summary>
	/// 强制指定是否设置 HTTP 304 状态码
	/// </summary>
	/// <param name="isSet">若为 <see cref="true"/> 则设置</param>
	/// <returns>返回 <paramref name="isSet"/></returns>
	public bool Set(bool isSet = true) {
		if (isSet) {
			Response.Clear();
			// Set the 304 status code.
			Response.StatusCode = (int)HttpStatusCode.NotModified;
		}
		_logger.LogDebug("{}设置 HTTP 304.", isSet ? "已" : "未");
		return isSet;
	}

	/// <summary>
	/// HTTP 协商缓存验证客户端缓存有效性
	/// </summary>
	/// <param name="withIP">是否带上 IP 地址</param>
	/// <param name="value">附加字符</param>
	/// <returns>如果有效，则为 <see cref="true"/>；否则为 <see cref="false"/></returns>
	public bool IsValid(bool withIP = false, string value = "") {

		ReadOnlySpan<char> ip = withIP ? _connection.RemoteAddress?.ToString() ?? "" : "";

        StringValues clientLastModifiedHeaders = Request.Headers.IfModifiedSince,
			clientETagHeaders = Request.Headers.IfNoneMatch;

        if (clientETagHeaders.Count == 1 && clientLastModifiedHeaders.Count == 1 && clientETagHeaders[0].Length == 50 && clientLastModifiedHeaders[0] == _lastModified) {

			using SHA256 sha256 = SHA256.Create();
			var clientETag = clientETagHeaders[0].AsSpan(1, 48);
			ReadOnlySpan<char> clientSHA256 = string.Concat(clientETag[..22], clientETag[27..]),
				clientSalt = clientETag[22..27];
			
			byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(string.Concat(ip, clientSalt, value)));
			return clientSHA256.ToString() == Convert.ToBase64String(hash)[..43];
		}
		return false;
	}

	/// <summary>
	/// 验证客户端缓存有效性，若有效，则设置 HTTP 304
	/// </summary>
	/// <param name="withIP">是否带上 IP 地址</param>
	/// <param name="value">附加字符</param>
	/// <returns>若已设置，则返回 <see cref="true"/>；否则返回 <see cref="false"/> 并向客户端输出相关响应头</returns>
	public bool TrySet(bool withIP = false, string value = "") {
		bool isValid = IsValid(withIP, value);

		if (!isValid) { // 若无效
			ReadOnlySpan<char> ip = withIP ? _connection.RemoteAddress?.ToString() ?? "" : "";
			
			string charList = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789`~!@#$%^&*()_+{}|:<>?-=[];',./"; // Salt 中可包含的字符列表
			StringBuilder sb = new();
			for (int i = 0; i < 5; i++) sb.Append(charList[Random.Shared.Next(charList.Length)]);
			ReadOnlySpan<char> salt = sb.ToString();
			sb.Clear();

			using var sha256 = SHA256.Create();
			ReadOnlySpan<char> hash = Convert.ToBase64String(sha256.ComputeHash(Encoding.UTF8.GetBytes(string.Concat(ip, salt, value))));

			Response.Headers.Add("Last-Modified", _lastModified);
			Response.Headers.Add("ETag", $"\"{string.Concat(hash[..22], salt, hash[22..43])}\"");
		}
		
		return Set(isValid);
	}


	/// <summary>
	/// HTTP 协商缓存验证客户端缓存有效性
	/// </summary>
	/// <param name="value">附加字符</param>
	/// <returns>如果有效，则为 <see cref="true"/>；否则为 <see cref="false"/></returns>
	public bool IsValid(string value = "") {
		return IsValid(false, value);
	}

	/// <summary>
	/// 验证客户端缓存有效性，若有效，则设置 HTTP 304
	/// </summary>
	/// <param name="value">附加字符</param>
	/// <returns>若已设置，则返回 <see cref="true"/>；否则返回 <see cref="false"/> 并向客户端输出相关响应头</returns>
	public bool TrySet(string value = "") {
		return TrySet(false, value);
	}
}