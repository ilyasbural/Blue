﻿namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class FeaturesInsideController : Controller
    {
        readonly IFeaturesInsideService Service;
        public FeaturesInsideController(IFeaturesInsideService service)
        {
            Service = service;
        }

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<FeaturesInsideViewModel>>(new List<FeaturesInsideViewModel>());
            Response<FeaturesInside> FeaturesInsideResponse = await Service.SelectAsync(new FeaturesInsideSelectDto { });
            foreach (FeaturesInside FeaturesInside in FeaturesInsideResponse.Collection)
            {
                FeaturesInsideViewModel ViewModel = new FeaturesInsideViewModel { Id = FeaturesInside.Id, Name = FeaturesInside.Name };
                Model.Item1.Add(ViewModel);
            }
            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<FeaturesInsideViewModel>(new FeaturesInsideViewModel());
            return View(Model);
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind(Prefix = "Item1")] FeaturesInsideViewModel Model)
        {
            FeaturesInsideRegisterDto FeaturesInside = new FeaturesInsideRegisterDto();
            FeaturesInside.Name = Model.Name;
            Response<FeaturesInside> Response = await Service.InsertAsync(FeaturesInside);
            if (Response.Success > 0) return RedirectToAction("Index");
            else return View(Model);
        }

        public async Task<IActionResult> Update(Guid Id)
        {
            var Model = Tuple.Create<FeaturesInsideViewModel>(new FeaturesInsideViewModel());
            Response<FeaturesInside> Response = await Service.SelectSingleAsync(new FeaturesInsideSelectDto { Id = Id });

            Model.Item1.Id = Response.Collection.First().Id;
            Model.Item1.Name = Response.Collection.First().Name;
            Model.Item1.RegisterDate = Response.Collection.First().RegisterDate;
            Model.Item1.UpdateDate = Response.Collection.First().UpdateDate;

            return View(Model);
        }

        [HttpPost]
        public async Task<IActionResult> Update([Bind(Prefix = "Item1")] FeaturesInsideViewModel Model)
        {
            FeaturesInsideUpdateDto FeaturesInside = new FeaturesInsideUpdateDto();
            FeaturesInside.Id = Model.Id;
            FeaturesInside.Name = Model.Name;
            Response<FeaturesInside> Response = await Service.UpdateAsync(FeaturesInside);
            if (Response.Success > 0) return RedirectToAction("Index");
            else return View(Model);
        }

        public async Task<IActionResult> Delete(Guid Id)
        {
            var Model = Tuple.Create<FeaturesInsideViewModel>(new FeaturesInsideViewModel());
            Response<FeaturesInside> Response = await Service.SelectSingleAsync(new FeaturesInsideSelectDto { Id = Id });

            Model.Item1.Id = Response.Collection.First().Id;
            Model.Item1.Name = Response.Collection.First().Name;
            Model.Item1.RegisterDate = Response.Collection.First().RegisterDate;
            Model.Item1.UpdateDate = Response.Collection.First().UpdateDate;

            return View(Model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([Bind(Prefix = "Item1")] FeaturesInsideViewModel Model)
        {
            FeaturesInsideDeleteDto FeaturesInside = new FeaturesInsideDeleteDto();
            FeaturesInside.Id = Model.Id;
            Response<FeaturesInside> Response = await Service.DeleteAsync(FeaturesInside);
            if (Response.Success > 0) return RedirectToAction("Index");
            else return View(Model);
        }
    }
}