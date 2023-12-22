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
            Response<Price> PriceResponse = await Service.SelectAsync(new PriceSelectDto { });
            foreach (Price Price in PriceResponse.Collection)
            {
                PriceViewModel ViewModel = new PriceViewModel { Id = Price.Id, Name = Price.Name };
                Model.Item1.Add(ViewModel);
            }
            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<PriceViewModel>(new PriceViewModel());
            return View(Model);
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind(Prefix = "Item1")] PriceViewModel Model)
        {
            PriceRegisterDto Price = new PriceRegisterDto();
            Price.Name = Model.Name;
            Response<Price> Response = await Service.InsertAsync(Price);
            if (Response.Success > 0) return RedirectToAction("Index");
            else return View(Model);
        }

        public async Task<IActionResult> Update(Guid Id)
        {
            var Model = Tuple.Create<PriceViewModel>(new PriceViewModel());
            Response<Price> Response = await Service.SelectSingleAsync(new PriceSelectDto { Id = Id });

            Model.Item1.Id = Response.Collection.First().Id;
            Model.Item1.Name = Response.Collection.First().Name;
            Model.Item1.RegisterDate = Response.Collection.First().RegisterDate;
            Model.Item1.UpdateDate = Response.Collection.First().UpdateDate;

            return View(Model);
        }

        public async Task<IActionResult> Delete(Guid Id)
        {
            var Model = Tuple.Create<PriceViewModel>(new PriceViewModel());
            Response<Price> Response = await Service.SelectSingleAsync(new PriceSelectDto { Id = Id });

            Model.Item1.Id = Response.Collection.First().Id;
            Model.Item1.Name = Response.Collection.First().Name;
            Model.Item1.RegisterDate = Response.Collection.First().RegisterDate;
            Model.Item1.UpdateDate = Response.Collection.First().UpdateDate;

            return View(Model);
        }
    }
}