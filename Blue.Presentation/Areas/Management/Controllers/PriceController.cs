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
				PriceViewModel ViewModel = new PriceViewModel { Id = Price.Id };
				Model.Item1.Add(ViewModel);
			}
			return View(Model);
		}

		public IActionResult Create()
		{
			var Model = Tuple.Create<PriceViewModel>(new PriceViewModel());

			//await Service.InsertAsync(new BuildingTypeRegisterDto { });

			return View(Model);
		}

		[HttpPost]
		public async Task<IActionResult> Create([Bind(Prefix = "Item1")] PriceViewModel Model)
		{
			PriceRegisterDto Price = new PriceRegisterDto();
			//BuildingType.Name = Model.Name;
			Response<Price> PriceResponse = await Service.InsertAsync(Price);
			if (PriceResponse.Success > 0) return RedirectToAction("Index");
			else return View(Model);
		}

		public IActionResult Update()
		{
			var Model = Tuple.Create<PriceViewModel>(new PriceViewModel());

			return View(Model);
		}

		public IActionResult Delete()
		{
			var Model = Tuple.Create<PriceViewModel>(new PriceViewModel());

			return View(Model);
		}
	}
}