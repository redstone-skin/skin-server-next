using System.Net.Sockets;

namespace SkinServerNext.Controllers {
	[ApiController]
	[Route("[controller]")]
	public class GetIPController : ControllerBase {
		private readonly ILogger<GetIPController> _logger;
		private readonly IHttpConnectionInfo _connection;
		private readonly IHttp304 _http304;

		public GetIPController(ILogger<GetIPController> logger, IHttpConnectionInfo connection, IHttp304 http304) {
			_logger = logger;
			_connection = connection;
			_http304 = http304;
		}

		[HttpGet]
		[ResponseCache(CacheProfileName = "Private1m")] // 客户端缓存1分钟
		public IP? Get() { // 获取 IP 地址
			var address = _connection.RemoteAddress;
			_logger.LogDebug("GetIP: Client {}:{}", address?.AddressFamily == AddressFamily.InterNetworkV6 ? $"[{address}]" : address, _connection.RemotePort);
			if (_http304.TrySet(true)) {
				return null;
			}
			return new(address);
		}
	}
}