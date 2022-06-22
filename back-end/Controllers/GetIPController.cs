using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers {
	[ApiController]
	[Route("[controller]")]
	public class GetIPController : ControllerBase {
		private readonly ILogger<GetIPController> _logger;

		public GetIPController(ILogger<GetIPController> logger) {
			_logger = logger;
		}

		[HttpGet]
		public IP Get() {
			return new(HttpContext.Connection.RemoteIpAddress);
		}
	}
}