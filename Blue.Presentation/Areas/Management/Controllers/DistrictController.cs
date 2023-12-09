namespace Blue.Platform.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class DistrictController : Controller
    {
        readonly IDistrictService Service;
        public DistrictController(IDistrictService service)
        {
            Service = service;
        }

        public IActionResult Index()
        {



            return View();
        }
    }
}