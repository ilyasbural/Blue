﻿namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class HometownController : Controller
    {
        readonly IHometownService Service;
        public HometownController(IHometownService service)
        {
            Service = service;
        }

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<HometownViewModel>>(new List<HometownViewModel>());
            Response<Hometown> HometownResponse = await Service.SelectAsync(new HometownSelectDto { });
            foreach (Hometown Hometown in HometownResponse.Collection)
            {
                HometownViewModel ViewModel = new HometownViewModel { Id = Hometown.Id, Name = Hometown.Name };
                Model.Item1.Add(ViewModel);
            }
            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<HometownViewModel>(new HometownViewModel());
            return View(Model);
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind(Prefix = "Item1")] HometownViewModel Model)
        {
            HometownRegisterDto Hometown = new HometownRegisterDto();
            Hometown.Name = Model.Name;
            Response<Hometown> Response = await Service.InsertAsync(Hometown);
            if (Response.Success > 0) return RedirectToAction("Index");
            else return View(Model);
        }

        public async Task<IActionResult> Update(Guid Id)
        {
            var Model = Tuple.Create<HometownViewModel>(new HometownViewModel());
            Response<Hometown> Response = await Service.SelectSingleAsync(new HometownSelectDto { Id = Id });

            Model.Item1.Id = Response.Collection.First().Id;
            Model.Item1.Name = Response.Collection.First().Name;
            Model.Item1.RegisterDate = Response.Collection.First().RegisterDate;
            Model.Item1.UpdateDate = Response.Collection.First().UpdateDate;

            return View(Model);
        }

        [HttpPost]
        public async Task<IActionResult> Update([Bind(Prefix = "Item1")] HometownViewModel Model)
        {
            HometownUpdateDto Hometown = new HometownUpdateDto();
            Hometown.Id = Model.Id;
            Hometown.Name = Model.Name;
            Response<Hometown> Response = await Service.UpdateAsync(Hometown);
            if (Response.Success > 0) return RedirectToAction("Index");
            else return View(Model);
        }

        public async Task<IActionResult> Delete(Guid Id)
        {
            var Model = Tuple.Create<HometownViewModel>(new HometownViewModel());
            Response<Hometown> Response = await Service.SelectSingleAsync(new HometownSelectDto { Id = Id });

            Model.Item1.Id = Response.Collection.First().Id;
            Model.Item1.Name = Response.Collection.First().Name;
            Model.Item1.RegisterDate = Response.Collection.First().RegisterDate;
            Model.Item1.UpdateDate = Response.Collection.First().UpdateDate;

            return View(Model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([Bind(Prefix = "Item1")] HometownViewModel Model)
        {
            HometownDeleteDto Hometown = new HometownDeleteDto();
            Hometown.Id = Model.Id;
            Response<Hometown> Response = await Service.DeleteAsync(Hometown);
            if (Response.Success > 0) return RedirectToAction("Index");
            else return View(Model);
        }
    }
}