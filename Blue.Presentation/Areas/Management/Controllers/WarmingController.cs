namespace Blue.Presentation.Areas.Management.Controllers
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
            var Model = Tuple.Create<List<WarmingViewModel>>(new List<WarmingViewModel>());

            //Service.InsertAsync(new WarmingRegisterDto { Name = "Var" });

            return View(Model);
        }
    }
}