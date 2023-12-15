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

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<FeaturesInsideViewModel>> (new List<FeaturesInsideViewModel>());
            Response<FeaturesInside> FeaturesInsideResponse = await Service.SelectAsync(new FeaturesInsideSelectDto {   });
            foreach (FeaturesInside FeaturesInside in FeaturesInsideResponse.Collection)
            {
                FeaturesInsideViewModel ViewModel = new FeaturesInsideViewModel { Id = FeaturesInside.Id };
                Model.Item1.Add(ViewModel);
            }
            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<FeaturesInsideViewModel>(new FeaturesInsideViewModel());

            //await Service.InsertAsync(new BuildingTypeRegisterDto { });

            return View(Model);
        }

		[HttpPost]
		public async Task<IActionResult> Create([Bind(Prefix = "Item1")] FeaturesInsideViewModel Model)
		{
			FeaturesInsideRegisterDto FeaturesInside = new FeaturesInsideRegisterDto();
			//BuildingType.Name = Model.Name;
			Response<FeaturesInside> FeaturesInsideResponse = await Service.InsertAsync(FeaturesInside);
			if (FeaturesInsideResponse.Success > 0) return RedirectToAction("Index");
			else return View(Model);
		}

		public IActionResult Update()
        {
            var Model = Tuple.Create<FeaturesInsideViewModel>(new FeaturesInsideViewModel());

            return View(Model);
        }

        public IActionResult Delete()
        {
            var Model = Tuple.Create<FeaturesInsideViewModel>(new FeaturesInsideViewModel());

            return View(Model);
        }
    }
}