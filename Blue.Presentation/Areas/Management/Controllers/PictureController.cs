namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class PictureController : Controller
    {
        readonly IPictureService Service;
        public PictureController(IPictureService service)
        {
            Service = service;
        }

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<PictureViewModel>>(new List<PictureViewModel>());
            Response<Picture> PictureResponse = await Service.SelectAsync(new PictureSelectDto { });

            //Model.Item1.Id = Response.Collection.First().Id;
            //Model.Item1.Name = Response.Collection.First().Name;
            //Model.Item1.RegisterDate = Response.Collection.First().RegisterDate;
            //Model.Item1.UpdateDate = Response.Collection.First().UpdateDate;

            //Service.InsertAsync(new PictureRegisterDto { });

            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<PictureViewModel>(new PictureViewModel());
            return View(Model);
        }

        public IActionResult Update(Guid Id)
        {
            var Model = Tuple.Create<PictureViewModel>(new PictureViewModel());
            return View(Model);
        }

        public IActionResult Delete(Guid Id)
        {
            var Model = Tuple.Create<PictureViewModel>(new PictureViewModel());
            return View(Model);
        }
    }
}