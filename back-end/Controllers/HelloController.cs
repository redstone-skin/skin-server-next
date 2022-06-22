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

		public HelloController(ILogger<HelloController> logger) {
			_logger = logger;
		}

		[HttpGet]
		public Hello Get() { // 打个招呼
			var connection = HttpContext.Connection;
			var address = connection.RemoteIpAddress;
			_logger.LogDebug("Hello! Client {}:{}", address?.AddressFamily == AddressFamily.InterNetworkV6 ? $"[{address}]" : address, connection.RemotePort);
			return new() { Slogan = Texts[Random.Shared.Next(Texts.Length)] };
		}
	}
}