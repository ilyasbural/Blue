namespace Blue.Platform.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class SizeController : Controller
    {
        readonly ISizeService Service;
        public SizeController(ISizeService service)
        {
            Service = service;
        }

        public IActionResult Index()
        {
            Service.InsertAsync(new SizeRegisterDto { Name = "75 m2" });
            return View();
        }
    }
}