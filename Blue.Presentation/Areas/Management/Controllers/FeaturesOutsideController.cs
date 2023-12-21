﻿namespace Blue.Presentation.Areas.Management.Controllers
{
	using Core;
	using Microsoft.AspNetCore.Mvc;

	[Area("Management")]
	public class FeaturesOutsideController : Controller
	{
		readonly IFeaturesOutsideService Service;
		public FeaturesOutsideController(IFeaturesOutsideService service)
		{
			Service = service;
		}

		public async Task<IActionResult> Index()
		{
			var Model = Tuple.Create<List<FeaturesOutsideViewModel>>(new List<FeaturesOutsideViewModel>());
			Response<FeaturesOutside> FeaturesOutsideResponse = await Service.SelectAsync(new FeaturesOutsideSelectDto { });
			foreach (FeaturesOutside FeaturesOutside in FeaturesOutsideResponse.Collection)
			{
				FeaturesOutsideViewModel ViewModel = new FeaturesOutsideViewModel { Id = FeaturesOutside.Id, Name = FeaturesOutside.Name };
				Model.Item1.Add(ViewModel);
			}
			return View(Model);
		}

		public IActionResult Create()
		{
			var Model = Tuple.Create<FeaturesOutsideViewModel>(new FeaturesOutsideViewModel());
			return View(Model);
		}

		[HttpPost]
		public async Task<IActionResult> Create([Bind(Prefix = "Item1")] FeaturesOutsideViewModel Model)
		{
			FeaturesOutsideRegisterDto FeaturesOutside = new FeaturesOutsideRegisterDto();
			FeaturesOutside.Name = Model.Name;
			Response<FeaturesOutside> Response = await Service.InsertAsync(FeaturesOutside);
			if (Response.Success > 0) return RedirectToAction("Index");
			else return View(Model);
		}

		public IActionResult Update(Guid Id)
		{
			var Model = Tuple.Create<FeaturesOutsideViewModel>(new FeaturesOutsideViewModel());
			return View(Model);
		}

		public IActionResult Delete(Guid Id)
		{
			var Model = Tuple.Create<FeaturesOutsideViewModel>(new FeaturesOutsideViewModel());
			return View(Model);
		}
	}
}