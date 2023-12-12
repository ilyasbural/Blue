namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class RoomController : Controller
    {
        readonly IRoomService Service;
        public RoomController(IRoomService service)
        {
            Service = service;
        }

        public IActionResult Index()
        {
            Service.InsertAsync(new RoomRegisterDto { });
            return View();
        }
    }
}