namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class DistrictController : Controller
    {
        readonly IDistrictService Service;
        public DistrictController(IDistrictService service)
        {
            Service = service;
        }

        public IActionResult Index()
        {
            var Model = Tuple.Create<List<DistrictViewModel>>(new List<DistrictViewModel>());

            //Service.InsertAsync(new DistrictRegisterDto { Name = "Aaaa" });

            return View(Model);
        }
    }
}