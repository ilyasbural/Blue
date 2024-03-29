﻿namespace Blue.Presentation.Areas.Management.Controllers
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

        public async Task<IActionResult> Update(Guid Id)
        {
            var Model = Tuple.Create<DistrictViewModel>(new DistrictViewModel());
            Response<District> Response = await Service.SelectSingleAsync(new DistrictSelectDto { Id = Id });

            Model.Item1.Id = Response.Collection.First().Id;
            Model.Item1.Name = Response.Collection.First().Name;
            Model.Item1.RegisterDate = Response.Collection.First().RegisterDate;
            Model.Item1.UpdateDate = Response.Collection.First().UpdateDate;

            return View(Model);
        }

        public async Task<IActionResult> Delete(Guid Id)
        {
            var Model = Tuple.Create<DistrictViewModel>(new DistrictViewModel());
            Response<District> Respomse = await Service.SelectSingleAsync(new DistrictSelectDto { Id = Id });

            return View(Model);
        }
    }
}