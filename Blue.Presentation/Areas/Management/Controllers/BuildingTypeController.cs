namespace Blue.Presentation.Areas.Management.Controllers
{
	using Core;
	using Microsoft.AspNetCore.Mvc;

	[Area("Management")]
	public class BuildingTypeController : Controller
	{
		readonly IBuildingTypeService Service;
		public BuildingTypeController(IBuildingTypeService service)
		{
			Service = service;
		}

		public async Task<IActionResult> Index()
		{
			var Model = Tuple.Create<List<BuildingTypeViewModel>>(new List<BuildingTypeViewModel>());
			Response<BuildingType> BuildingTypeResponse = await Service.SelectAsync(new BuildingTypeSelectDto { });
			foreach (BuildingType BuildingType in BuildingTypeResponse.Collection)
			{
				BuildingTypeViewModel ViewModel = new BuildingTypeViewModel { Id = BuildingType.Id };
				Model.Item1.Add(ViewModel);
			}
			return View(Model);
		}

		public IActionResult Create()
		{
			var Model = Tuple.Create<BuildingTypeViewModel>(new BuildingTypeViewModel());
			return View(Model);
		}

		public IActionResult Update()
		{
			var Model = Tuple.Create<BuildingTypeViewModel>(new BuildingTypeViewModel());
			return View(Model);
		}

		public IActionResult Delete()
		{
			var Model = Tuple.Create<BuildingTypeViewModel>(new BuildingTypeViewModel());
			return View(Model);
		}
	}
}