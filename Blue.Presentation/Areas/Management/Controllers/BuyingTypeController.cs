namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class BuyingTypeController : Controller
    {
        readonly IBuyingTypeService Service;
        public BuyingTypeController(IBuyingTypeService service)
        {
            Service = service;
        }

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<BuyingTypeViewModel>> (new List<BuyingTypeViewModel>());
            Response<BuyingType> BuyingTypeResponse = await Service.SelectAsync(new BuyingTypeSelectDto { });
            foreach (BuyingType BuyingType in BuyingTypeResponse.Collection)
            {
                BuyingTypeViewModel ViewModel = new BuyingTypeViewModel { Id = BuyingType.Id };
                Model.Item1.Add(ViewModel);
            }
            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<BuyingTypeViewModel>(new BuyingTypeViewModel());

            //await Service.InsertAsync(new BuildingTypeRegisterDto { });

            return View(Model);
        }

        public IActionResult Update()
        {
            var Model = Tuple.Create<BuyingTypeViewModel>(new BuyingTypeViewModel());

            return View(Model);
        }

        public IActionResult Delete()
        {
            var Model = Tuple.Create<BuyingTypeViewModel>(new BuyingTypeViewModel());

            return View(Model);
        }
    }
}