using System.Net;

namespace SkinServerNext.Services.Interfaces;
public interface IHttpConnectionInfo {
	IPAddress? RemoteAddress { get; init; }
	int RemotePort { get; init; }
	IPAddress LocalAddress { get; init; }
	int LocalPort { get; init; }
	string Protocol { get; init; }
}