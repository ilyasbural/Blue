namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class FeaturesOutsideController : Controller
    {
        readonly IFeaturesOutsideService Service;
        public FeaturesOutsideController(IFeaturesOutsideService service)
        {
            Service = service;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}