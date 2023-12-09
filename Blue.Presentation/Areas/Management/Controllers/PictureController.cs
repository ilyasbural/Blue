namespace Blue.Platform.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class PictureController : Controller
    {
        readonly IPictureService Service;
        public PictureController(IPictureService service)
        {
            Service = service;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}