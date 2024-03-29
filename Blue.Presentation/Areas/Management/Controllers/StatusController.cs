﻿namespace Blue.Presentation.Areas.Management.Controllers
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
                StatusViewModel ViewModel = new StatusViewModel { Id = Status.Id, Name = Status.Name };
                Model.Item1.Add(ViewModel);
            }
            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<StatusViewModel>(new StatusViewModel());
            return View(Model);
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind(Prefix = "Item1")] StatusViewModel Model)
        {
            StatusRegisterDto Status = new StatusRegisterDto();
            Status.Name = Model.Name;
            Response<Status> Response = await Service.InsertAsync(Status);
            if (Response.Success > 0) return RedirectToAction("Index");
            else return View(Model);
        }

        public async Task<IActionResult> Update(Guid Id)
        {
            var Model = Tuple.Create<StatusViewModel>(new StatusViewModel());
            Response<Status> Response = await Service.SelectSingleAsync(new StatusSelectDto { Id = Id });

            Model.Item1.Id = Response.Collection.First().Id;
            Model.Item1.Name = Response.Collection.First().Name;
            Model.Item1.RegisterDate = Response.Collection.First().RegisterDate;
            Model.Item1.UpdateDate = Response.Collection.First().UpdateDate;

            return View(Model);
        }

        [HttpPost]
        public async Task<IActionResult> Update([Bind(Prefix = "Item1")] StatusViewModel Model)
        {
            StatusUpdateDto Status = new StatusUpdateDto();
            Status.Id = Model.Id;
            Status.Name = Model.Name;
            Response<Status> Response = await Service.UpdateAsync(Status);
            if (Response.Success > 0) return RedirectToAction("Index");
            else return View(Model);
        }

        public async Task<IActionResult> Delete(Guid Id)
        {
            var Model = Tuple.Create<StatusViewModel>(new StatusViewModel());
            Response<Status> Response = await Service.SelectSingleAsync(new StatusSelectDto { Id = Id });

            Model.Item1.Id = Response.Collection.First().Id;
            Model.Item1.Name = Response.Collection.First().Name;
            Model.Item1.RegisterDate = Response.Collection.First().RegisterDate;
            Model.Item1.UpdateDate = Response.Collection.First().UpdateDate;

            return View(Model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([Bind(Prefix = "Item1")] StatusViewModel Model)
        {
            StatusDeleteDto Status = new StatusDeleteDto();
            Status.Id = Model.Id;
            Response<Status> Response = await Service.DeleteAsync(Status);
            if (Response.Success > 0) return RedirectToAction("Index");
            else return View(Model);
        }
    }
}