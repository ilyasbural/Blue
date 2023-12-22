namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class FeaturesAroundController : Controller
    {
        readonly IFeaturesAroundService Service;
        public FeaturesAroundController(IFeaturesAroundService service)
        {
            Service = service;
        }

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<FeaturesAroundViewModel>>(new List<FeaturesAroundViewModel>());
            Response<FeaturesAround> FeaturesAroundResponse = await Service.SelectAsync(new FeaturesAroundSelectDto { });
            foreach (FeaturesAround FeaturesAround in FeaturesAroundResponse.Collection)
            {
                FeaturesAroundViewModel ViewModel = new FeaturesAroundViewModel { Id = FeaturesAround.Id, Name = FeaturesAround.Name };
                Model.Item1.Add(ViewModel);
            }
            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<FeaturesAroundViewModel>(new FeaturesAroundViewModel());
            return View(Model);
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind(Prefix = "Item1")] FeaturesAroundViewModel Model)
        {
            FeaturesAroundRegisterDto FeaturesAround = new FeaturesAroundRegisterDto();
            FeaturesAround.Name = Model.Name;
            Response<FeaturesAround> Response = await Service.InsertAsync(FeaturesAround);
            if (Response.Success > 0) return RedirectToAction("Index");
            else return View(Model);
        }

        public async Task<IActionResult> Update(Guid Id)
        {
            var Model = Tuple.Create<FeaturesAroundViewModel>(new FeaturesAroundViewModel());
            Response<FeaturesAround> Response = await Service.SelectSingleAsync(new FeaturesAroundSelectDto { Id = Id });

            Model.Item1.Id = Response.Collection.First().Id;
            Model.Item1.Name = Response.Collection.First().Name;
            Model.Item1.RegisterDate = Response.Collection.First().RegisterDate;
            Model.Item1.UpdateDate = Response.Collection.First().UpdateDate;

            return View(Model);
        }

        public async Task<IActionResult> Delete(Guid Id)
        {
            var Model = Tuple.Create<FeaturesAroundViewModel>(new FeaturesAroundViewModel());
            Response<FeaturesAround> Response = await Service.SelectSingleAsync(new FeaturesAroundSelectDto { Id = Id });

            Model.Item1.Id = Response.Collection.First().Id;
            Model.Item1.Name = Response.Collection.First().Name;
            Model.Item1.RegisterDate = Response.Collection.First().RegisterDate;
            Model.Item1.UpdateDate = Response.Collection.First().UpdateDate;

            return View(Model);
        }
    }
}