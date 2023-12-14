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

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<PriceViewModel>>(new List<PriceViewModel>());

            await Service.SelectAsync(new PriceSelectDto {    });

            //Service.InsertAsync(new PriceRegisterDto { Name = "100.000" });

            return View(Model);
        }
    }
}