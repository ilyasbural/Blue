namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class FuelTypeController : Controller
    {
        readonly IFuelTypeService Service;
        public FuelTypeController(IFuelTypeService service)
        {
            Service = service;
        }

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<FuelTypeViewModel>> (new List<FuelTypeViewModel>());
            Response<FuelType> FuelTypeResponse = await Service.SelectAsync(new FuelTypeSelectDto {  });
            foreach (FuelType FuelType in FuelTypeResponse.Collection)
            {
                FuelTypeViewModel ViewModel = new FuelTypeViewModel { Id = FuelType.Id };
                Model.Item1.Add(ViewModel);
            }
            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<FuelTypeViewModel>(new FuelTypeViewModel());

            //await Service.InsertAsync(new BuildingTypeRegisterDto { });

            return View(Model);
        }

        public IActionResult Update()
        {
            var Model = Tuple.Create<FuelTypeViewModel>(new FuelTypeViewModel());

            return View(Model);
        }

        public IActionResult Delete()
        {
            var Model = Tuple.Create<FuelTypeViewModel>(new FuelTypeViewModel());

            return View(Model);
        }
    }
}