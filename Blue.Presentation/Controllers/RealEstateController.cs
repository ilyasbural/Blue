namespace Blue.Platform.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    public class RealEstateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}