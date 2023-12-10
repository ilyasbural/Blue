namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class FromWhoController : Controller
    {
        readonly IFromWhoService Service;
        public FromWhoController(IFromWhoService service)
        {
            Service = service;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}