namespace Blue.Presentation.Areas.Management.Controllers
{
	using Core;
	using Microsoft.AspNetCore.Mvc;

	[Area("Management")]
	public class DistrictController : Controller
	{
		readonly IDistrictService Service;
		public DistrictController(IDistrictService service)
		{
			Service = service;
		}

		public async Task<IActionResult> Index()
		{
			var Model = Tuple.Create<List<DistrictViewModel>>(new List<DistrictViewModel>());
			Response<District> DistrictResponse = await Service.SelectAsync(new DistrictSelectDto { });
			foreach (District District in DistrictResponse.Collection)
			{
				DistrictViewModel ViewModel = new DistrictViewModel { Id = District.Id };
				Model.Item1.Add(ViewModel);
			}
			return View(Model);
		}

		public IActionResult Create()
		{
			var Model = Tuple.Create<DistrictViewModel>(new DistrictViewModel());
			return View(Model);
		}

		[HttpPost]
		public async Task<IActionResult> Create([Bind(Prefix = "Item1")] DistrictViewModel Model)
		{
			DistrictRegisterDto District = new DistrictRegisterDto();
			District.Name = Model.Name;
			Response<District> Response = await Service.InsertAsync(District);
			if (Response.Success > 0) return RedirectToAction("Index");
			else return View(Model);
		}

		public IActionResult Update(Guid Id)
		{
			var Model = Tuple.Create<DistrictViewModel>(new DistrictViewModel());
			return View(Model);
		}

		public IActionResult Delete(Guid Id)
		{
			var Model = Tuple.Create<DistrictViewModel>(new DistrictViewModel());
			return View(Model);
		}
	}
}