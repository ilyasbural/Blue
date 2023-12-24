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
            var Model = Tuple.Create<List<FuelTypeViewModel>>(new List<FuelTypeViewModel>());
            Response<FuelType> FuelTypeResponse = await Service.SelectAsync(new FuelTypeSelectDto { });
            foreach (FuelType FuelType in FuelTypeResponse.Collection)
            {
                FuelTypeViewModel ViewModel = new FuelTypeViewModel { Id = FuelType.Id, Name = FuelType.Name };
                Model.Item1.Add(ViewModel);
            }
            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<FuelTypeViewModel>(new FuelTypeViewModel());
            return View(Model);
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind(Prefix = "Item1")] FuelTypeViewModel Model)
        {
            FuelTypeRegisterDto FuelType = new FuelTypeRegisterDto();
            FuelType.Name = Model.Name;
            Response<FuelType> Response = await Service.InsertAsync(FuelType);
            if (Response.Success > 0) return RedirectToAction("Index");
            else return View(Model);
        }

        public async Task<IActionResult> Update(Guid Id)
        {
            var Model = Tuple.Create<FuelTypeViewModel>(new FuelTypeViewModel());
            Response<FuelType> Response = await Service.SelectSingleAsync(new FuelTypeSelectDto { Id = Id });

            Model.Item1.Id = Response.Collection.First().Id;
            Model.Item1.Name = Response.Collection.First().Name;
            Model.Item1.RegisterDate = Response.Collection.First().RegisterDate;
            Model.Item1.UpdateDate = Response.Collection.First().UpdateDate;

            return View(Model);
        }

        [HttpPost]
        public async Task<IActionResult> Update([Bind(Prefix = "Item1")] FuelTypeViewModel Model)
        {
            FuelTypeUpdateDto FuelType = new FuelTypeUpdateDto();
            FuelType.Id = Model.Id;
            FuelType.Name = Model.Name;
            Response<FuelType> Response = await Service.UpdateAsync(FuelType);
            if (Response.Success > 0) return RedirectToAction("Index");
            else return View(Model);
        }

        public async Task<IActionResult> Delete(Guid Id)
        {
            var Model = Tuple.Create<FuelTypeViewModel>(new FuelTypeViewModel());
            Response<FuelType> Response = await Service.SelectSingleAsync(new FuelTypeSelectDto { Id = Id });

            Model.Item1.Id = Response.Collection.First().Id;
            Model.Item1.Name = Response.Collection.First().Name;
            Model.Item1.RegisterDate = Response.Collection.First().RegisterDate;
            Model.Item1.UpdateDate = Response.Collection.First().UpdateDate;

            return View(Model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([Bind(Prefix = "Item1")] FuelTypeViewModel Model)
        {
            FuelTypeDeleteDto FuelType = new FuelTypeDeleteDto();
            FuelType.Id = Model.Id;
            Response<FuelType> Response = await Service.DeleteAsync(FuelType);
            if (Response.Success > 0) return RedirectToAction("Index");
            else return View(Model);
        }
    }
}