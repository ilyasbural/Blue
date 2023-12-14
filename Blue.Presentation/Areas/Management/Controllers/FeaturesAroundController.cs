﻿namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class FeaturesAroundController : Controller
    {
        readonly IFeaturesAroundService Service;
        public FeaturesAroundController(IFeaturesAroundService service)
        {
            Service = service;
        }

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<FeaturesAroundViewModel>>(new List<FeaturesAroundViewModel>());

            await Service.SelectAsync(new FeaturesAroundSelectDto {       });

            //Service.InsertAsync(new FeaturesAroundRegisterDto { });

            return View(Model);
        }
    }
}