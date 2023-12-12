namespace Blue.Platform.Areas.Management.Controllers
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

        public IActionResult Index()
        {
            CityRegisterDto cityRegisterDto = new CityRegisterDto();
            cityRegisterDto.Name = "İstanbul";
            Service.InsertAsync(cityRegisterDto);
            return View();
        }
    }
}