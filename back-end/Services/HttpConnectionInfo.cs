using System.Net;

namespace SkinServerNext.Services;
public class HttpConnectionInfo : IHttpConnectionInfo {
	public HttpConnectionInfo(IHttpContextAccessor accessor) {
		var connection = accessor.HttpContext!.Connection;
		RemoteAddress = connection.RemoteIpAddress;
		RemotePort = connection.RemotePort;
		LocalAddress = connection.LocalIpAddress!;
		LocalPort = connection.LocalPort;
	}

	public IPAddress? RemoteAddress { get; init; }
	public int RemotePort { get; init; }
	public IPAddress LocalAddress { get; init; }
	public int LocalPort { get; init; }
}