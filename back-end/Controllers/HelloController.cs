using Microsoft.AspNetCore.Mvc;
using SkinServerNext.Models;

namespace SkinServerNext.Controllers {
	[ApiController]
	[Route("[controller]")]
	public class HelloController : ControllerBase {
		private readonly string[] Texts = new[] { "Next - RedstoneSkin", "Next Redstone Skin Site.", "OHHHHHH! Next Redstone Skin!" };

		private readonly ILogger<HelloController> _logger;

		public HelloController(ILogger<HelloController> logger) {
			_logger = logger;
		}

		[HttpGet(Name = "GetHello")]
		public Hello Get() {
			Random random = new();
			return new() { Text = Texts[random.Next(Texts.Length)] };
		}
	}
}