﻿namespace Blue.Presentation.Areas.Management.Controllers
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
            Response<Room> RoomResponse = await Service.SelectAsync(new RoomSelectDto { });
            foreach (Room Room in RoomResponse.Collection)
            {
                RoomViewModel ViewModel = new RoomViewModel { Id = Room.Id, Name = Room.Name };
                Model.Item1.Add(ViewModel);
            }
            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<RoomViewModel>(new RoomViewModel());
            return View(Model);
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind(Prefix = "Item1")] RoomViewModel Model)
        {
            RoomRegisterDto Room = new RoomRegisterDto();
            Room.Name = Model.Name;
            Response<Room> Response = await Service.InsertAsync(Room);
            if (Response.Success > 0) return RedirectToAction("Index");
            else return View(Model);
        }

        public async Task<IActionResult> Update(Guid Id)
        {
            var Model = Tuple.Create<RoomViewModel>(new RoomViewModel());
            Response<Room> Response = await Service.SelectSingleAsync(new RoomSelectDto { Id = Id });

            Model.Item1.Id = Response.Collection.First().Id;
            Model.Item1.Name = Response.Collection.First().Name;
            Model.Item1.RegisterDate = Response.Collection.First().RegisterDate;
            Model.Item1.UpdateDate = Response.Collection.First().UpdateDate;

            return View(Model);
        }

        [HttpPost]
        public async Task<IActionResult> Update([Bind(Prefix = "Item1")] RoomViewModel Model)
        {
            RoomUpdateDto Room = new RoomUpdateDto();
            Room.Id = Model.Id;
            Room.Name = Model.Name;
            Response<Room> Response = await Service.UpdateAsync(Room);
            if (Response.Success > 0) return RedirectToAction("Index");
            else return View(Model);
        }

        public async Task<IActionResult> Delete(Guid Id)
        {
            var Model = Tuple.Create<RoomViewModel>(new RoomViewModel());
            Response<Room> Response = await Service.SelectSingleAsync(new RoomSelectDto { Id = Id });

            Model.Item1.Id = Response.Collection.First().Id;
            Model.Item1.Name = Response.Collection.First().Name;
            Model.Item1.RegisterDate = Response.Collection.First().RegisterDate;
            Model.Item1.UpdateDate = Response.Collection.First().UpdateDate;

            return View(Model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([Bind(Prefix = "Item1")] RoomViewModel Model)
        {
            RoomDeleteDto Room = new RoomDeleteDto();
            Room.Id = Model.Id;
            Response<Room> Response = await Service.DeleteAsync(Room);
            if (Response.Success > 0) return RedirectToAction("Index");
            else return View(Model);
        }
    }
}