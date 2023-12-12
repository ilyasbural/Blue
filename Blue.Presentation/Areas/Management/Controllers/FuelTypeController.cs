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
            Service.InsertAsync(new FuelTypeRegisterDto { });
            return View();
        }
    }
}