namespace Blue.Platform.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class WarmingController : Controller
    {
        readonly IWarmingService Service;
        public WarmingController(IWarmingService service)
        {
            Service = service;
        }

        public IActionResult Index()
        {
            Service.InsertAsync(new WarmingRegisterDto { Name = "Var" });
            return View();
        }
    }
}