namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class PriceController : Controller
    {
        readonly IPriceService Service;
        public PriceController(IPriceService service)
        {
            Service = service;
        }

        public IActionResult Index()
        {
            var Model = Tuple.Create<List<PriceViewModel>>(new List<PriceViewModel>());

            //Service.InsertAsync(new PriceRegisterDto { Name = "100.000" });

            return View(Model);
        }
    }
}