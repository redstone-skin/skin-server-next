using System.Net;

namespace SkinServerNext.Services;
public class HttpConnectionInfo : IHttpConnectionInfo {
	public HttpConnectionInfo(IHttpContextAccessor accessor) {
		var context = accessor.HttpContext!;
		var connection = context.Connection;
		RemoteAddress = connection.RemoteIpAddress;
		RemotePort = connection.RemotePort;
		LocalAddress = connection.LocalIpAddress!;
		LocalPort = connection.LocalPort;
		Protocol = context.Request.Protocol;
	}

	public IPAddress? RemoteAddress { get; init; }
	public int RemotePort { get; init; }
	public IPAddress LocalAddress { get; init; }
	public int LocalPort { get; init; }
	public string Protocol { get; init; }
}