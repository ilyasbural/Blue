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

            await Service.SelectAsync(new DistrictSelectDto {         });

            //Service.InsertAsync(new DistrictRegisterDto { Name = "Aaaa" });

            return View(Model);
        }
    }
}