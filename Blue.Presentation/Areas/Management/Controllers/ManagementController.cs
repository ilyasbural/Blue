namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class ManagementController : Controller
    {
        readonly IManagementService Service;
        public ManagementController(IManagementService service)
        {
            Service = service;
        }

        public IActionResult Index()
        {
            var Model = Tuple.Create<List<ManagementViewModel>>(new List<ManagementViewModel>());

            //Service.InsertAsync(new ManagementRegisterDto { });

            return View(Model);
        }
    }
}