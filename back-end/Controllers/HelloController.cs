using System.Net.Sockets;

namespace SkinServerNext.Controllers {
	[ApiController]
	[Route("[controller]")]
	public class HelloController : ControllerBase {
		private readonly string[] Texts = new[] {
			"Next - RedstoneSkin",
			"Next Redstone Skin Site.",
			"OHHHHHH! Next Redstone Skin!",
			"下一站 - 红石皮肤站",
			"Welcome to Next Redstone Skin Site!",
			"欢迎光临“下一站 - 红石皮肤站”！",
			"全新的红石皮肤站！",
			"API of Redstone Skin",
			"哎呀，不知道写什么好呢。"
		};

		private readonly ILogger<HelloController> _logger;
		private readonly IHttpConnectionInfo _connection;

		public HelloController(ILogger<HelloController> logger, IHttpConnectionInfo connection) {
			_logger = logger;
			_connection = connection;
		}

		[HttpGet]
		public Hello Get() { // 打个招呼
			var address = _connection.RemoteAddress;
			_logger.LogDebug("GetIP: Client {}:{}", address?.AddressFamily == AddressFamily.InterNetworkV6 ? $"[{address}]" : address, _connection.RemotePort);
			return new() { Slogan = Texts[Random.Shared.Next(Texts.Length)] };
		}
	}
}