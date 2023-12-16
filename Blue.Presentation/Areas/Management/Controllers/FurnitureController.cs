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
				FurnitureViewModel ViewModel = new FurnitureViewModel { Id = Furniture.Id };
				Model.Item1.Add(ViewModel);
			}
			return View(Model);
		}

		public IActionResult Create()
		{
			var Model = Tuple.Create<FurnitureViewModel>(new FurnitureViewModel());

			//await Service.InsertAsync(new BuildingTypeRegisterDto { });

			return View(Model);
		}

		[HttpPost]
		public async Task<IActionResult> Create([Bind(Prefix = "Item1")] FurnitureViewModel Model)
		{
			FurnitureRegisterDto Furniture = new FurnitureRegisterDto();
			//Furniture.Name = Model.Name;
			Response<Furniture> FurnitureResponse = await Service.InsertAsync(Furniture);

			if (FurnitureResponse.Success > 0) return RedirectToAction("Index");
			else return View(Model);
		}

		public IActionResult Update()
		{
			var Model = Tuple.Create<FurnitureViewModel>(new FurnitureViewModel());

			return View(Model);
		}

		public IActionResult Delete()
		{
			var Model = Tuple.Create<FurnitureViewModel>(new FurnitureViewModel());

			return View(Model);
		}
	}
}