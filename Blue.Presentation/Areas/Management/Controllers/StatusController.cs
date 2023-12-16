namespace Blue.Presentation.Areas.Management.Controllers
{
	using Core;
	using Microsoft.AspNetCore.Mvc;

	[Area("Management")]
	public class StatusController : Controller
	{
		readonly IStatusService Service;
		public StatusController(IStatusService service)
		{
			Service = service;
		}

		public async Task<IActionResult> Index()
		{
			var Model = Tuple.Create<List<StatusViewModel>>(new List<StatusViewModel>());
			Response<Status> StatusResponse = await Service.SelectAsync(new StatusSelectDto { });
			foreach (Status Status in StatusResponse.Collection)
			{
				StatusViewModel ViewModel = new StatusViewModel { Id = Status.Id };
				Model.Item1.Add(ViewModel);
			}
			return View(Model);
		}

		public IActionResult Create()
		{
			var Model = Tuple.Create<StatusViewModel>(new StatusViewModel());

			//await Service.InsertAsync(new BuildingTypeRegisterDto { });

			return View(Model);
		}

		[HttpPost]
		public async Task<IActionResult> Create([Bind(Prefix = "Item1")] StatusViewModel Model)
		{
			StatusRegisterDto Status = new StatusRegisterDto();
			//BuildingType.Name = Model.Name;
			Response<Status> StatusResponse = await Service.InsertAsync(Status);
			if (StatusResponse.Success > 0) return RedirectToAction("Index");
			else return View(Model);
		}

		public IActionResult Update()
		{
			var Model = Tuple.Create<StatusViewModel>(new StatusViewModel());

			return View(Model);
		}

		public IActionResult Delete()
		{
			var Model = Tuple.Create<StatusViewModel>(new StatusViewModel());

			return View(Model);
		}
	}
}