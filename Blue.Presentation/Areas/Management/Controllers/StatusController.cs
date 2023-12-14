namespace Blue.Presentation.Areas.Management.Controllers
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

        public IActionResult Index()
        {
            var Model = Tuple.Create<List<StatusViewModel>>(new List<StatusViewModel>());

            //Service.InsertAsync(new StatusRegisterDto { });

            return View(Model);
        }
    }
}