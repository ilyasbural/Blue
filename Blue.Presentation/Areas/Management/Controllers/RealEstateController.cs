namespace Blue.Platform.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class RealEstateController : Controller
    {
        readonly IRealEstateService Service;
        public RealEstateController(IRealEstateService service)
        {
            Service = service;
        }

        public IActionResult Index()
        {
            Service.InsertAsync(new RealEstateRegisterDto { });
            return View();
        }
    }
}