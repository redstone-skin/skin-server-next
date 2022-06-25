using System.Net.Sockets;

namespace SkinServerNext.Controllers;
[ApiController]
[Route("[controller]")]
public class GetIPController : ControllerBase {
	private readonly ILogger<GetIPController> _logger;
	private readonly IHttpConnectionInfo _info;
	private readonly IHttp304 _http304;

	public GetIPController(ILogger<GetIPController> logger, IHttpConnectionInfo info, IHttp304 http304) {
		_logger = logger;
		_info = info;
		_http304 = http304;
	}

	[HttpGet]
	[ResponseCache(CacheProfileName = "Private1m")] // 客户端缓存1分钟
	public IP? Get() { // 获取 IP 地址
		var address = _info.RemoteAddress;
		_logger.LogDebug("GetIP: Client {}:{} on {}", address?.AddressFamily == AddressFamily.InterNetworkV6 ? $"[{address}]" : address, _info.RemotePort, _info.Protocol);
		if (_http304.TrySet(true)) return null;
		return new(_info);
	}
}