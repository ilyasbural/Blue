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

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<RoomViewModel>>(new List<RoomViewModel>());

            await Service.SelectAsync(new RoomSelectDto {         });

            //Service.InsertAsync(new RoomRegisterDto { });

            return View(Model);
        }
    }
}