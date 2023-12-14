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

            await Service.SelectAsync(new StatusSelectDto {       });

            //Service.InsertAsync(new StatusRegisterDto { });

            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<StatusViewModel>(new StatusViewModel());

            //await Service.InsertAsync(new BuildingTypeRegisterDto { });

            return View(Model);
        }

        public IActionResult Update()
        {
            var Model = Tuple.Create<StatusViewModel>(new StatusViewModel());

            return View(Model);
        }

        public IActionResult Delete()
        {
            var Model = Tuple.Create<StatusViewModel>(new StatusViewModel());

            return View(Model);
        }
    }
}