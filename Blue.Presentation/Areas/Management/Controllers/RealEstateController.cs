namespace Blue.Presentation.Areas.Management.Controllers
{
	using Core;
	using Microsoft.AspNetCore.Mvc;

	[Area("Management")]
	public class RealEstateController : Controller
	{
		readonly IRealEstateService Service;
		public RealEstateController(IRealEstateService service)
		{
			Service = service;
		}

		public async Task<IActionResult> Index()
		{
			var Model = Tuple.Create<List<RealEstateViewModel>>(new List<RealEstateViewModel>());
			Response<RealEstate> RealEstateResponse = await Service.SelectAsync(new RealEstateSelectDto { });
			foreach (RealEstate RealEstate in RealEstateResponse.Collection)
			{
				RealEstateViewModel ViewModel = new RealEstateViewModel { Id = RealEstate.Id, Name = RealEstate.Name };
				Model.Item1.Add(ViewModel);
			}
			return View(Model);
		}

		public IActionResult Create()
		{
			var Model = Tuple.Create<RealEstateViewModel, RealEstateDetailViewModel>(new RealEstateViewModel(), new RealEstateDetailViewModel());
			return View(Model);
		}

		[HttpPost]
		public async Task<IActionResult> Create([Bind(Prefix = "Item1")] RealEstateViewModel Model)
		{
			RealEstateRegisterDto RealEstate = new RealEstateRegisterDto();
			RealEstate.Name = Model.Name;
			Response<RealEstate> Response = await Service.InsertAsync(RealEstate);
			if (Response.Success > 0) return RedirectToAction("Index");
			else return View(Model);
		}

		public async Task<IActionResult> Update(Guid Id)
		{
			var Model = Tuple.Create<RealEstateViewModel, RealEstateDetailViewModel>(new RealEstateViewModel(), new RealEstateDetailViewModel());
			Response<RealEstate> Response = await Service.SelectSingleAsync(new RealEstateSelectDto { Id = Id });

            Model.Item1.Id = Response.Collection.First().Id;
            Model.Item1.Name = Response.Collection.First().Name;
            Model.Item1.RegisterDate = Response.Collection.First().RegisterDate;
            Model.Item1.UpdateDate = Response.Collection.First().UpdateDate;

            return View(Model);
		}

		public async Task<IActionResult> Delete(Guid Id)
		{
			var Model = Tuple.Create<RealEstateViewModel, RealEstateDetailViewModel>(new RealEstateViewModel(), new RealEstateDetailViewModel());
			return View(Model);
		}
	}
}