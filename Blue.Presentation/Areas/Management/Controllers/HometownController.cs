namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class HometownController : Controller
    {
        readonly IHometownService Service;
        public HometownController(IHometownService service)
        {
            Service = service;
        }

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<HometownViewModel>>(new List<HometownViewModel>());

            await Service.SelectAsync(new HometownSelectDto {         });

            //Service.InsertAsync(new HometownRegisterDto { });

            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<HometownViewModel>(new HometownViewModel());

            //await Service.InsertAsync(new BuildingTypeRegisterDto { });

            return View(Model);
        }
    }
}