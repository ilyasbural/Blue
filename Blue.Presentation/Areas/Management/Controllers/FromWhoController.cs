﻿namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class FromWhoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}