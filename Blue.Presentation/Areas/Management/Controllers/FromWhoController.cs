namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class FromWhoController : Controller
    {
        readonly IFromWhoService Service;
        public FromWhoController(IFromWhoService service)
        {
            Service = service;
        }

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<FromWhoViewModel>>(new List<FromWhoViewModel>());
            Response<FromWho> FromWhoResponse = await Service.SelectAsync(new FromWhoSelectDto { });
            foreach (FromWho FromWho in FromWhoResponse.Collection)
            {
                FromWhoViewModel ViewModel = new FromWhoViewModel { Id = FromWho.Id, Name = FromWho.Name };
                Model.Item1.Add(ViewModel);
            }
            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<FromWhoViewModel>(new FromWhoViewModel());
            return View(Model);
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind(Prefix = "Item1")] FromWhoViewModel Model)
        {
            FromWhoRegisterDto FromWho = new FromWhoRegisterDto();
            FromWho.Name = Model.Name;
            Response<FromWho> Response = await Service.InsertAsync(FromWho);
            if (Response.Success > 0) return RedirectToAction("Index");
            else return View(Model);
        }

        public async Task<IActionResult> Update(Guid Id)
        {
            var Model = Tuple.Create<FromWhoViewModel>(new FromWhoViewModel());
            Response<FromWho> Response = await Service.SelectSingleAsync(new FromWhoSelectDto { Id = Id });

            Model.Item1.Id = Response.Collection.First().Id;
            Model.Item1.Name = Response.Collection.First().Name;
            Model.Item1.RegisterDate = Response.Collection.First().RegisterDate;
            Model.Item1.UpdateDate = Response.Collection.First().UpdateDate;

            return View(Model);
        }

        [HttpPost]
        public async Task<IActionResult> Update([Bind(Prefix = "Item1")] FromWhoViewModel Model)
        {
            FromWhoUpdateDto FromWho = new FromWhoUpdateDto();
            FromWho.Id = Model.Id;
            FromWho.Name = Model.Name;
            Response<FromWho> Response = await Service.UpdateAsync(FromWho);
            if (Response.Success > 0) return RedirectToAction("Index");
            else return View(Model);
        }

        public async Task<IActionResult> Delete(Guid Id)
        {
            var Model = Tuple.Create<FromWhoViewModel>(new FromWhoViewModel());
            Response<FromWho> Response = await Service.SelectSingleAsync(new FromWhoSelectDto { Id = Id });

            Model.Item1.Id = Response.Collection.First().Id;
            Model.Item1.Name = Response.Collection.First().Name;
            Model.Item1.RegisterDate = Response.Collection.First().RegisterDate;
            Model.Item1.UpdateDate = Response.Collection.First().UpdateDate;

            return View(Model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([Bind(Prefix = "Item1")] FromWhoViewModel Model)
        {
            FromWhoDeleteDto FromWho = new FromWhoDeleteDto();
            FromWho.Id = Model.Id;
            Response<FromWho> Response = await Service.DeleteAsync(FromWho);
            if (Response.Success > 0) return RedirectToAction("Index");
            else return View(Model);
        }
    }
}