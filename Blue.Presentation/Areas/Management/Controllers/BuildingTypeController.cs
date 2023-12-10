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

        public IActionResult Index()
        {
            return View();
        }
    }
}