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

            await Service.SelectAsync(new FuelTypeSelectDto {         });

            //Service.InsertAsync(new FuelTypeRegisterDto { });

            return View(Model);
        }
    }
}