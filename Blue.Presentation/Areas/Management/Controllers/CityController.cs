namespace Blue.Presentation.Areas.Management.Controllers
{
	using Core;
	using Microsoft.AspNetCore.Mvc;

	[Area("Management")]
	public class CityController : Controller
	{
		readonly ICityService Service;
		public CityController(ICityService service)
		{
			Service = service;
		}

		public async Task<IActionResult> Index()
		{
			var Model = Tuple.Create<List<CityViewModel>>(new List<CityViewModel>());
			Response<City> CityResponse = await Service.SelectAsync(new CitySelectDto { });
			foreach (City City in CityResponse.Collection)
			{
				CityViewModel ViewModel = new CityViewModel { Id = City.Id, Name = City.Name };
				Model.Item1.Add(ViewModel);
			}
			return View(Model);
		}

		public IActionResult Create()
		{
			var Model = Tuple.Create<CityViewModel>(new CityViewModel());
			return View(Model);
		}

		[HttpPost]
		public async Task<IActionResult> Create([Bind(Prefix = "Item1")] CityViewModel Model)
		{
			CityRegisterDto City = new CityRegisterDto();
			City.Name = Model.Name;
			Response<City> Response = await Service.InsertAsync(City);
			if (Response.Success > 0) return RedirectToAction("Index");
			else return View(Model);
		}

		public async Task<IActionResult> Update(Guid Id)
		{
			var Model = Tuple.Create<CityViewModel>(new CityViewModel());
			Response<City> Response =  await Service.SelectSingleAsync(new CitySelectDto { Id = Id });

			Model.Item1.Id = Response.Collection.First().Id;
			Model.Item1.Name = Response.Collection.First().Name;
			Model.Item1.RegisterDate = Response.Collection.First().RegisterDate;
			Model.Item1.UpdateDate = Response.Collection.First().UpdateDate;

			return View(Model);
		}

		public async Task<IActionResult> Delete(Guid Id)
		{
			var Model = Tuple.Create<CityViewModel>(new CityViewModel());
			Response<City> Response = await Service.SelectSingleAsync(new CitySelectDto { Id = Id });



			return View(Model);
		}
	}
}