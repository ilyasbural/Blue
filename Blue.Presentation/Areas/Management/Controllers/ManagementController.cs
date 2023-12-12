namespace Blue.Platform.Areas.Management.Controllers
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
            Service.InsertAsync(new ManagementRegisterDto { });
            return View();
        }
    }
}