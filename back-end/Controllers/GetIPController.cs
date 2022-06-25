using System.Net.Sockets;

namespace SkinServerNext.Controllers {
	[ApiController]
	[Route("[controller]")]
	public class GetIPController : ControllerBase {
		private readonly ILogger<GetIPController> _logger;
		private readonly IHttpConnectionInfo _connection;

		public GetIPController(ILogger<GetIPController> logger, IHttpConnectionInfo connection) {
			_logger = logger;
			_connection = connection;
		}

		[HttpGet]
		public IP Get() { // 获取 IP 地址
			var address = _connection.RemoteAddress;
			_logger.LogDebug("GetIP: Client {}:{}", address?.AddressFamily == AddressFamily.InterNetworkV6 ? $"[{address}]" : address, _connection.RemotePort);
			return new(address);
		}
	}
}