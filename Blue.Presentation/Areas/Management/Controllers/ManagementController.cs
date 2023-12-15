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

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<ManagementViewModel>> (new List<ManagementViewModel>());
            Response<Management> ManagementResponse = await Service.SelectAsync(new ManagementSelectDto {    });

            //Service.InsertAsync(new ManagementRegisterDto { });

            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<ManagementViewModel>(new ManagementViewModel());

            //await Service.InsertAsync(new BuildingTypeRegisterDto { });

            return View(Model);
        }

        public IActionResult Update()
        {
            var Model = Tuple.Create<ManagementViewModel>(new ManagementViewModel());

            return View(Model);
        }

        public IActionResult Delete()
        {
            var Model = Tuple.Create<ManagementViewModel>(new ManagementViewModel());

            return View(Model);
        }
    }
}