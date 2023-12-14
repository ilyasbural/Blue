namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class FurnitureController : Controller
    {
        readonly IFurnitureService Service;
        public FurnitureController(IFurnitureService service)
        {
            Service = service;
        }

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<FurnitureViewModel>>(new List<FurnitureViewModel>());

            await Service.SelectAsync(new FurnitureSelectDto {        });

            //Service.InsertAsync(new FurnitureRegisterDto { Name = "Var" });

            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<FurnitureViewModel>(new FurnitureViewModel());

            //await Service.InsertAsync(new BuildingTypeRegisterDto { });

            return View(Model);
        }

        public IActionResult Update()
        {
            var Model = Tuple.Create<FurnitureViewModel>(new FurnitureViewModel());

            return View(Model);
        }

        public IActionResult Delete()
        {
            var Model = Tuple.Create<FurnitureViewModel>(new FurnitureViewModel());

            return View(Model);
        }
    }
}