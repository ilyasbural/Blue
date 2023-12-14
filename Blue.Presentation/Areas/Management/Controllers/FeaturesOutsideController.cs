namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class FeaturesOutsideController : Controller
    {
        readonly IFeaturesOutsideService Service;
        public FeaturesOutsideController(IFeaturesOutsideService service)
        {
            Service = service;
        }

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<FeaturesOutsideViewModel>>(new List<FeaturesOutsideViewModel>());

            await Service.SelectAsync(new FeaturesOutsideSelectDto {      });

            //Service.InsertAsync(new FeaturesOutsideRegisterDto { });

            return View(Model);
        }
    }
}