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

        public IActionResult Index()
        {
            var Model = Tuple.Create<List<FurnitureViewModel>>(new List<FurnitureViewModel>());

            //Service.InsertAsync(new FurnitureRegisterDto { Name = "Var" });

            return View(Model);
        }
    }
}