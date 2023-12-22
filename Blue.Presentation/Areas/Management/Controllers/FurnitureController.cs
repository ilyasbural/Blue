namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class FurnitureController : Controller
    {
        readonly IFurnitureService Service;
        public FurnitureController(IFurnitureService service)
        {
            Service = service;
        }

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<FurnitureViewModel>>(new List<FurnitureViewModel>());
            Response<Furniture> FurnitureResponse = await Service.SelectAsync(new FurnitureSelectDto { });
            foreach (Furniture Furniture in FurnitureResponse.Collection)
            {
                FurnitureViewModel ViewModel = new FurnitureViewModel { Id = Furniture.Id, Name = Furniture.Name };
                Model.Item1.Add(ViewModel);
            }
            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<FurnitureViewModel>(new FurnitureViewModel());
            return View(Model);
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind(Prefix = "Item1")] FurnitureViewModel Model)
        {
            FurnitureRegisterDto Furniture = new FurnitureRegisterDto();
            Furniture.Name = Model.Name;
            Response<Furniture> Response = await Service.InsertAsync(Furniture);
            if (Response.Success > 0) return RedirectToAction("Index");
            else return View(Model);
        }

        public async Task<IActionResult> Update(Guid Id)
        {
            var Model = Tuple.Create<FurnitureViewModel>(new FurnitureViewModel());
            Response<Furniture> Response = await Service.SelectSingleAsync(new FurnitureSelectDto { Id = Id });

            Model.Item1.Id = Response.Collection.First().Id;
            Model.Item1.Name = Response.Collection.First().Name;
            Model.Item1.RegisterDate = Response.Collection.First().RegisterDate;
            Model.Item1.UpdateDate = Response.Collection.First().UpdateDate;

            return View(Model);
        }

		[HttpPost]
		public async Task<IActionResult> Update([Bind(Prefix = "Item1")] FurnitureViewModel Model)
		{
			FurnitureUpdateDto Furniture = new FurnitureUpdateDto();
            Furniture.Id = Model.Id;
			Furniture.Name = Model.Name;
			Response<Furniture> Response = await Service.UpdateAsync(Furniture);
			if (Response.Success > 0) return RedirectToAction("Index");
			else return View(Model);
		}

		public async Task<IActionResult> Delete(Guid Id)
        {
            var Model = Tuple.Create<FurnitureViewModel>(new FurnitureViewModel());
            Response<Furniture> Response = await Service.SelectSingleAsync(new FurnitureSelectDto { Id = Id });

            Model.Item1.Id = Response.Collection.First().Id;
            Model.Item1.Name = Response.Collection.First().Name;
            Model.Item1.RegisterDate = Response.Collection.First().RegisterDate;
            Model.Item1.UpdateDate = Response.Collection.First().UpdateDate;

            return View(Model);
        }

		[HttpPost]
		public async Task<IActionResult> Delete([Bind(Prefix = "Item1")] FurnitureViewModel Model)
		{
			FurnitureDeleteDto Furniture = new FurnitureDeleteDto();
			Furniture.Id = Model.Id;
			Response<Furniture> Response = await Service.DeleteAsync(Furniture);
			if (Response.Success > 0) return RedirectToAction("Index");
			else return View(Model);
		}
	}
}