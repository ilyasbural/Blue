namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class TypeController : Controller
    {
        readonly ITypeService Service;
        public TypeController(ITypeService service)
        {
            Service = service;
        }

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<TypeViewModel>> (new List<TypeViewModel>());
            Response<Type> TypeResponse = await Service.SelectAsync(new TypeSelectDto {         });

            //Service.InsertAsync(new TypeRegisterDto { Name = "Villa" });

            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<TypeViewModel>(new TypeViewModel());

            //await Service.InsertAsync(new BuildingTypeRegisterDto { });

            return View(Model);
        }

        public IActionResult Update()
        {
            var Model = Tuple.Create<TypeViewModel>(new TypeViewModel());

            return View(Model);
        }

        public IActionResult Delete()
        {
            var Model = Tuple.Create<TypeViewModel>(new TypeViewModel());

            return View(Model);
        }
    }
}