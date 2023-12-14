namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class FeaturesInsideController : Controller
    {
        readonly IFeaturesInsideService Service;
        public FeaturesInsideController(IFeaturesInsideService service)
        {
            Service = service;
        }

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<FeaturesInsideViewModel>>(new List<FeaturesInsideViewModel>());

            await Service.SelectAsync(new FeaturesInsideSelectDto {       });

            //Service.InsertAsync(new FeaturesInsideRegisterDto { });

            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<FeaturesInsideViewModel>(new FeaturesInsideViewModel());

            //await Service.InsertAsync(new BuildingTypeRegisterDto { });

            return View(Model);
        }
    }
}