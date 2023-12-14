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

        public IActionResult Index()
        {
            var Model = Tuple.Create<List<FuelTypeViewModel>>(new List<FuelTypeViewModel>());

            //Service.InsertAsync(new FuelTypeRegisterDto { });

            return View(Model);
        }
    }
}