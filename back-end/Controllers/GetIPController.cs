using System.Net.Sockets;

namespace SkinServerNext.Controllers {
	[ApiController]
	[Route("[controller]")]
	public class GetIPController : ControllerBase {
		private readonly ILogger<GetIPController> _logger;

		public GetIPController(ILogger<GetIPController> logger) {
			_logger = logger;
		}

		[HttpGet]
		public IP Get() { // 获取 IP 地址
			var connection = HttpContext.Connection;
			var address = connection.RemoteIpAddress;
			_logger.LogDebug("GetIP: Client {}:{}", address?.AddressFamily == AddressFamily.InterNetworkV6 ? $"[{address}]" : address, connection.RemotePort);
			return new(HttpContext.Connection.RemoteIpAddress);
		}
	}
}