﻿namespace Blue.Presentation.Areas.Management.Controllers
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
                BuildingTypeViewModel ViewModel = new BuildingTypeViewModel { Id = BuildingType.Id, Name = BuildingType.Name };
                Model.Item1.Add(ViewModel);
            }
            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<BuildingTypeViewModel>(new BuildingTypeViewModel());
            return View(Model);
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind(Prefix = "Item1")] BuildingTypeViewModel Model)
        {
            BuildingTypeRegisterDto BuildingType = new BuildingTypeRegisterDto();
            BuildingType.Name = Model.Name;
            Response<BuildingType> Response = await Service.InsertAsync(BuildingType);
            if (Response.Success > 0) return RedirectToAction("Index");
            else return View(Model);
        }

        public async Task<IActionResult> Update(Guid Id)
        {
            var Model = Tuple.Create<BuildingTypeViewModel>(new BuildingTypeViewModel());
            Response<BuildingType> Response = await Service.SelectSingleAsync(new BuildingTypeSelectDto { Id = Id });

            Model.Item1.Id = Response.Collection.First().Id;
            Model.Item1.Name = Response.Collection.First().Name;
            Model.Item1.RegisterDate = Response.Collection.First().RegisterDate;
            Model.Item1.UpdateDate = Response.Collection.First().UpdateDate;

            return View(Model);
        }

        [HttpPost]
        public async Task<IActionResult> Update([Bind(Prefix = "Item1")] BuildingTypeViewModel Model)
        {
            BuildingTypeUpdateDto BuildingType = new BuildingTypeUpdateDto();
            BuildingType.Id = Model.Id;
            BuildingType.Name = Model.Name;
            BuildingType.RegisterDate = Model.RegisterDate;
            BuildingType.UpdateDate = Model.UpdateDate;

            Response<BuildingType> Response = await Service.UpdateAsync(BuildingType);
            if (Response.Success > 0) return RedirectToAction("Index");
            else return View(Model);
        }

        public async Task<IActionResult> Delete(Guid Id)
        {
            var Model = Tuple.Create<BuildingTypeViewModel>(new BuildingTypeViewModel());
            Response<BuildingType> Response = await Service.SelectSingleAsync(new BuildingTypeSelectDto { Id = Id });

            Model.Item1.Id = Response.Collection.First().Id;
            Model.Item1.Name = Response.Collection.First().Name;
            Model.Item1.RegisterDate = Response.Collection.First().RegisterDate;
            Model.Item1.UpdateDate = Response.Collection.First().UpdateDate;

            return View(Model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([Bind(Prefix = "Item1")] BuildingTypeViewModel Model)
        {
            BuildingTypeDeleteDto BuildingType = new BuildingTypeDeleteDto();
            BuildingType.Id = Model.Id;
            Response<BuildingType> Response = await Service.DeleteAsync(BuildingType);
            if (Response.Success > 0) return RedirectToAction("Index");
            else return View(Model);
        }
    }
}