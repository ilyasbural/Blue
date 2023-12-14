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

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<FeaturesOutsideViewModel>>(new List<FeaturesOutsideViewModel>());

            await Service.SelectAsync(new FeaturesOutsideSelectDto {      });

            //Service.InsertAsync(new FeaturesOutsideRegisterDto { });

            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<FeaturesOutsideViewModel>(new FeaturesOutsideViewModel());

            //await Service.InsertAsync(new BuildingTypeRegisterDto { });

            return View(Model);
        }

        public IActionResult Update()
        {
            var Model = Tuple.Create<FeaturesOutsideViewModel>(new FeaturesOutsideViewModel());

            return View(Model);
        }

        public IActionResult Delete()
        {
            var Model = Tuple.Create<FeaturesOutsideViewModel>(new FeaturesOutsideViewModel());

            return View(Model);
        }
    }
}