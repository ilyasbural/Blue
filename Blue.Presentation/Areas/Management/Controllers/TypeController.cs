namespace Blue.Platform.Areas.Management.Controllers
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
            Service.InsertAsync(new TypeRegisterDto { Name = "Villa" });
            return View();
        }
    }
}