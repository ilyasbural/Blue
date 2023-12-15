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
            var Model = Tuple.Create<List<RoomViewModel>> (new List<RoomViewModel>());
            Response<Room> RoomResponse = await Service.SelectAsync(new RoomSelectDto {         });
            foreach (Room Room in RoomResponse.Collection)
            {
                RoomViewModel ViewModel = new RoomViewModel { Id = Room.Id };
                Model.Item1.Add(ViewModel);
            }
            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<RoomViewModel>(new RoomViewModel());

            //await Service.InsertAsync(new BuildingTypeRegisterDto { });

            return View(Model);
        }

        public IActionResult Update()
        {
            var Model = Tuple.Create<RoomViewModel>(new RoomViewModel());

            return View(Model);
        }

        public IActionResult Delete()
        {
            var Model = Tuple.Create<RoomViewModel>(new RoomViewModel());

            return View(Model);
        }
    }
}