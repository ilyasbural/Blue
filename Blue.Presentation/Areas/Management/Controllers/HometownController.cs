namespace Blue.Presentation.Areas.Management.Controllers
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

        public IActionResult Index()
        {
            return View();
        }
    }
}