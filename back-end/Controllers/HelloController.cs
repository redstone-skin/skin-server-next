using Microsoft.AspNetCore.Mvc;
using SkinServerNext.Models;

namespace SkinServerNext.Controllers {
	[ApiController]
	[Route("[controller]")]
	public class HelloController : ControllerBase {
		private readonly string[] Texts = new[] {
			"Next - RedstoneSkin",
			"Next Redstone Skin Site.",
			"OHHHHHH! Next Redstone Skin!",
			"��һվ - ��ʯƤ��վ",
			"Welcome to Next Redstone Skin Site!",
			"��ӭ���١���һվ - ��ʯƤ��վ����",
			"ȫ�µĺ�ʯƤ��վ��",
			"API of Redstone Skin",
			"��ѽ����֪��дʲô���ء�"
		};

		private readonly ILogger<HelloController> _logger;

		public HelloController(ILogger<HelloController> logger) {
			_logger = logger;
		}

		[HttpGet]
		public Hello Get() {
			return new() { Slogan = Texts[Random.Shared.Next(Texts.Length)] };
		}
	}
}