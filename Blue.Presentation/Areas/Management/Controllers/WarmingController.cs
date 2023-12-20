namespace Blue.Presentation.Areas.Management.Controllers
{
	using Core;
	using Microsoft.AspNetCore.Mvc;

	[Area("Management")]
	public class WarmingController : Controller
	{
		readonly IWarmingService Service;
		public WarmingController(IWarmingService service)
		{
			Service = service;
		}

		public async Task<IActionResult> Index()
		{
			var Model = Tuple.Create<List<WarmingViewModel>>(new List<WarmingViewModel>());
			Response<Warming> WarmingResponse = await Service.SelectAsync(new WarmingSelectDto { });
			foreach (Warming Warming in WarmingResponse.Collection)
			{
				WarmingViewModel ViewModel = new WarmingViewModel { Id = Warming.Id };
				Model.Item1.Add(ViewModel);
			}
			return View(Model);
		}

		public IActionResult Create()
		{
			var Model = Tuple.Create<WarmingViewModel>(new WarmingViewModel());
			return View(Model);
		}

		[HttpPost]
		public async Task<IActionResult> Create([Bind(Prefix = "Item1")] WarmingViewModel Model)
		{
			WarmingRegisterDto Warming = new WarmingRegisterDto();
			Warming.Name = Model.Name;
			Response<Warming> Response = await Service.InsertAsync(Warming);
			if (Response.Success > 0) return RedirectToAction("Index");
			else return View();
		}

		public IActionResult Update(Guid Id)
		{
			var Model = Tuple.Create<WarmingViewModel>(new WarmingViewModel());
			return View(Model);
		}

		public IActionResult Delete()
		{
			var Model = Tuple.Create<WarmingViewModel>(new WarmingViewModel());

			return View(Model);
		}
	}
}