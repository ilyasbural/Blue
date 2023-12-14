namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class FeaturesInsideController : Controller
    {
        readonly IFeaturesInsideService Service;
        public FeaturesInsideController(IFeaturesInsideService service)
        {
            Service = service;
        }

        public IActionResult Index()
        {
            var Model = Tuple.Create<List<FeaturesInsideViewModel>>(new List<FeaturesInsideViewModel>());

            //Service.InsertAsync(new FeaturesInsideRegisterDto { });

            return View(Model);
        }
    }
}