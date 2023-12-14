﻿namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class CityController : Controller
    {
        readonly ICityService Service;
        public CityController(ICityService service)
        {
            Service = service;
        }

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<CityViewModel>>(new List<CityViewModel>());

            Response<City> Response = await Service.SelectAsync(new CitySelectDto {         });

            //CityRegisterDto cityRegisterDto = new CityRegisterDto();
            //cityRegisterDto.Name = "İstanbul";
            //Service.InsertAsync(cityRegisterDto);

            return View(Model);
        }
    }
}