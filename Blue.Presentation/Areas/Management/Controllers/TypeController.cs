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

        public IActionResult Index()
        {
            var Model = Tuple.Create<List<TypeViewModel>>(new List<TypeViewModel>());

            //Service.InsertAsync(new TypeRegisterDto { Name = "Villa" });

            return View(Model);
        }
    }
}