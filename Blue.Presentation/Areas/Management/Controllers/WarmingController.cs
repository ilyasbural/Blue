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
				WarmingViewModel ViewModel = new WarmingViewModel { Id = Warming.Id, Name = Warming.Name };
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

        public async Task<IActionResult> Update(Guid Id)
        {
            var Model = Tuple.Create<WarmingViewModel>(new WarmingViewModel());
            Response<Warming> Response = await Service.SelectSingleAsync(new WarmingSelectDto { Id = Id });

            Model.Item1.Id = Response.Collection.First().Id;
            Model.Item1.Name = Response.Collection.First().Name;
            Model.Item1.RegisterDate = Response.Collection.First().RegisterDate;
            Model.Item1.UpdateDate = Response.Collection.First().UpdateDate;

            return View(Model);
        }

        public async Task<IActionResult> Delete(Guid Id)
		{
			var Model = Tuple.Create<WarmingViewModel>(new WarmingViewModel());
			return View(Model);
		}
	}
}