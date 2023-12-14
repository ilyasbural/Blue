namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class RealEstateController : Controller
    {
        readonly IRealEstateService Service;
        public RealEstateController(IRealEstateService service)
        {
            Service = service;
        }

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<RealEstateViewModel>>(new List<RealEstateViewModel>());

            await Service.SelectAsync(new RealEstateSelectDto {       });

            //Service.InsertAsync(new RealEstateRegisterDto { });

            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<RealEstateViewModel>(new RealEstateViewModel());

            //await Service.InsertAsync(new BuildingTypeRegisterDto { });

            return View(Model);
        }
    }
}