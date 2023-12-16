namespace Blue.Presentation.Areas.Management.Controllers
{
	using Core;
	using Microsoft.AspNetCore.Mvc;

	[Area("Management")]
	public class LoginController : Controller
	{
		public LoginController()
		{

		}

		public IActionResult Index()
		{
			return View();
		}
	}
}