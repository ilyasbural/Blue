namespace Blue.Presentation.Areas.Management.Controllers
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

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<SizeViewModel>>(new List<SizeViewModel>());

            await Service.SelectAsync(new SizeSelectDto {         });

            //Service.InsertAsync(new SizeRegisterDto { Name = "75 m2" });

            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<SizeViewModel>(new SizeViewModel());

            //await Service.InsertAsync(new BuildingTypeRegisterDto { });

            return View(Model);
        }

        public IActionResult Update()
        {
            var Model = Tuple.Create<SizeViewModel>(new SizeViewModel());

            return View(Model);
        }

        public IActionResult Delete()
        {
            var Model = Tuple.Create<SizeViewModel>(new SizeViewModel());

            return View(Model);
        }
    }
}