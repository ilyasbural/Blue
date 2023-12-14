namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class PriceController : Controller
    {
        readonly IPriceService Service;
        public PriceController(IPriceService service)
        {
            Service = service;
        }

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<PriceViewModel>>(new List<PriceViewModel>());

            await Service.SelectAsync(new PriceSelectDto {    });

            //Service.InsertAsync(new PriceRegisterDto { Name = "100.000" });

            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<PriceViewModel>(new PriceViewModel());

            //await Service.InsertAsync(new BuildingTypeRegisterDto { });

            return View(Model);
        }

        public IActionResult Update()
        {
            var Model = Tuple.Create<PriceViewModel>(new PriceViewModel());

            return View(Model);
        }

        public IActionResult Delete()
        {
            var Model = Tuple.Create<PriceViewModel>(new PriceViewModel());

            return View(Model);
        }
    }
}