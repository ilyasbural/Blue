namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class CityController : Controller
    {
        readonly ICityService Service;
        public CityController(ICityService service)
        {
            Service = service;
        }

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<CityViewModel>> (new List<CityViewModel>());
            Response<City> CityResponse = await Service.SelectAsync(new CitySelectDto {  });
            foreach (City City in CityResponse.Collection)
            {
                CityViewModel ViewModel = new CityViewModel { Id = City.Id };
                Model.Item1.Add(ViewModel);
            }
            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<CityViewModel>(new CityViewModel());

            //await Service.InsertAsync(new BuildingTypeRegisterDto { });

            return View(Model);
        }

        public IActionResult Update()
        {
            var Model = Tuple.Create<CityViewModel>(new CityViewModel());

            return View(Model);
        }

        public IActionResult Delete()
        {
            var Model = Tuple.Create<CityViewModel>(new CityViewModel());

            return View(Model);
        }
    }
}