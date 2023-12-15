namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class FeaturesAroundController : Controller
    {
        readonly IFeaturesAroundService Service;
        public FeaturesAroundController(IFeaturesAroundService service)
        {
            Service = service;
        }

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<FeaturesAroundViewModel>> (new List<FeaturesAroundViewModel>());
            Response<FeaturesAround> FeaturesAroundResponse = await Service.SelectAsync(new FeaturesAroundSelectDto {  });

            //Service.InsertAsync(new FeaturesAroundRegisterDto { });

            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<FeaturesAroundViewModel>(new FeaturesAroundViewModel());

            //await Service.InsertAsync(new BuildingTypeRegisterDto { });

            return View(Model);
        }

        public IActionResult Update()
        {
            var Model = Tuple.Create<FeaturesAroundViewModel>(new FeaturesAroundViewModel());

            return View(Model);
        }

        public IActionResult Delete()
        {
            var Model = Tuple.Create<FeaturesAroundViewModel>(new FeaturesAroundViewModel());

            return View(Model);
        }
    }
}