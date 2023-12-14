namespace Blue.Presentation.Areas.Management.Controllers
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

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<DistrictViewModel>>(new List<DistrictViewModel>());

            await Service.SelectAsync(new DistrictSelectDto {         });

            //Service.InsertAsync(new DistrictRegisterDto { Name = "Aaaa" });

            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<DistrictViewModel>(new DistrictViewModel());

            //await Service.InsertAsync(new BuildingTypeRegisterDto { });

            return View(Model);
        }

        public IActionResult Update()
        {
            var Model = Tuple.Create<DistrictViewModel>(new DistrictViewModel());

            return View(Model);
        }

        public IActionResult Delete()
        {
            var Model = Tuple.Create<DistrictViewModel>(new DistrictViewModel());

            return View(Model);
        }
    }
}