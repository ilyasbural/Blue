namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class SizeController : Controller
    {
        readonly ISizeService Service;
        public SizeController(ISizeService service)
        {
            Service = service;
        }

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<SizeViewModel>>(new List<SizeViewModel>());
            Response<Size> SizeResponse = await Service.SelectAsync(new SizeSelectDto { });
            foreach (Size Size in SizeResponse.Collection)
            {
                SizeViewModel ViewModel = new SizeViewModel { Id = Size.Id, Name = Size.Name };
                Model.Item1.Add(ViewModel);
            }
            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<SizeViewModel>(new SizeViewModel());
            return View(Model);
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind(Prefix = "Item1")] SizeViewModel Model)
        {
            SizeRegisterDto Size = new SizeRegisterDto();
            Size.Name = Model.Name;
            Response<Size> Response = await Service.InsertAsync(Size);
            if (Response.Success > 0) return RedirectToAction("Index");
            else return View(Model);
        }

        public async Task<IActionResult> Update(Guid Id)
        {
            var Model = Tuple.Create<SizeViewModel>(new SizeViewModel());
            Response<Size> Response = await Service.SelectSingleAsync(new SizeSelectDto { Id = Id });

            Model.Item1.Id = Response.Collection.First().Id;
            Model.Item1.Name = Response.Collection.First().Name;
            Model.Item1.RegisterDate = Response.Collection.First().RegisterDate;
            Model.Item1.UpdateDate = Response.Collection.First().UpdateDate;

            return View(Model);
        }

		[HttpPost]
		public async Task<IActionResult> Update([Bind(Prefix = "Item1")] SizeViewModel Model)
		{
			SizeUpdateDto Size = new SizeUpdateDto();
            Size.Id = Model.Id;
			Size.Name = Model.Name;
			Response<Size> Response = await Service.UpdateAsync(Size);
			if (Response.Success > 0) return RedirectToAction("Index");
			else return View(Model);
		}

		public async Task<IActionResult> Delete(Guid Id)
        {
            var Model = Tuple.Create<SizeViewModel>(new SizeViewModel());
            Response<Size> Response = await Service.SelectSingleAsync(new SizeSelectDto { Id = Id });

            Model.Item1.Id = Response.Collection.First().Id;
            Model.Item1.Name = Response.Collection.First().Name;
            Model.Item1.RegisterDate = Response.Collection.First().RegisterDate;
            Model.Item1.UpdateDate = Response.Collection.First().UpdateDate;

            return View(Model);
        }
    }
}