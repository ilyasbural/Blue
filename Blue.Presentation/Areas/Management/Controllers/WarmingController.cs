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

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<WarmingViewModel>>(new List<WarmingViewModel>());

            await Service.SelectAsync(new WarmingSelectDto {      });

            //Service.InsertAsync(new WarmingRegisterDto { Name = "Var" });

            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<WarmingViewModel>(new WarmingViewModel());

            //await Service.InsertAsync(new BuildingTypeRegisterDto { });

            return View(Model);
        }

        public IActionResult Update()
        {
            var Model = Tuple.Create<WarmingViewModel>(new WarmingViewModel());

            return View(Model);
        }

        public IActionResult Delete()
        {
            var Model = Tuple.Create<WarmingViewModel>(new WarmingViewModel());

            return View(Model);
        }
    }
}