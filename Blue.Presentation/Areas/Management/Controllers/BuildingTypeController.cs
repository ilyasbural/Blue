namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class BuildingTypeController : Controller
    {
        readonly IBuildingTypeService Service;
        public BuildingTypeController(IBuildingTypeService service)
        {
            Service = service;
        }

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<BuildingTypeViewModel>>(new List<BuildingTypeViewModel>());

            Response<BuildingType> Response = await Service.SelectAsync(new BuildingTypeSelectDto {    });

            //Service.InsertAsync(new BuildingTypeRegisterDto { });

            return View(Model);
        }
    }
}