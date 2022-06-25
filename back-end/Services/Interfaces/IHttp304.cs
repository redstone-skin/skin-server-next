namespace SkinServerNext.Services.Interfaces;
public interface IHttp304 {
	/// <summary>
	/// 强制指定是否设置 HTTP 304 状态码
	/// </summary>
	/// <param name="isSet">若为 <see cref="true"/> 则设置</param>
	/// <returns>返回 <paramref name="isSet"/></returns>
	public bool Set(bool isSet = true);

	/// <summary>
	/// HTTP 协商缓存验证客户端缓存有效性
	/// </summary>
	/// <param name="withIP">是否带上 IP 地址</param>
	/// <param name="value">附加字符</param>
	/// <returns>如果有效，则为 <see cref="true"/>；否则为 <see cref="false"/></returns>
	public bool IsValid(bool withIP = false, string value = "");

	/// <summary>
	/// 验证客户端缓存有效性，若有效，则设置 HTTP 304
	/// </summary>
	/// <param name="withIP">是否带上 IP 地址</param>
	/// <param name="value">附加字符</param>
	/// <returns>若已设置，则返回 <see cref="true"/>；否则返回 <see cref="false"/> 并向客户端输出相关响应头</returns>
	public bool TrySet(bool withIP = false, string value = "");

	/// <summary>
	/// HTTP 协商缓存验证客户端缓存有效性
	/// </summary>
	/// <param name="value">附加字符</param>
	/// <returns>如果有效，则为 <see cref="true"/>；否则为 <see cref="false"/></returns>
	public bool IsValid(string value = "");

	/// <summary>
	/// 验证客户端缓存有效性，若有效，则设置 HTTP 304
	/// </summary>
	/// <param name="value">附加字符</param>
	/// <returns>若已设置，则返回 <see cref="true"/>；否则返回 <see cref="false"/> 并向客户端输出相关响应头</returns>
	public bool TrySet(string value = "");
}