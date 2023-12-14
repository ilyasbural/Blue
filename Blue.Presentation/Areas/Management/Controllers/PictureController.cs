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

            await Service.SelectAsync(new PictureSelectDto {      });

            //Service.InsertAsync(new PictureRegisterDto { });

            return View(Model);
        }
    }
}