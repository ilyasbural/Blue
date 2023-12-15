namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class FromWhoController : Controller
    {
        readonly IFromWhoService Service;
        public FromWhoController(IFromWhoService service)
        {
            Service = service;
        }

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<FromWhoViewModel>> (new List<FromWhoViewModel>());
            Response<FromWho> FromWhoResponse = await Service.SelectAsync(new FromWhoSelectDto {   });
            foreach (FromWho FromWho in FromWhoResponse.Collection)
            {
                FromWhoViewModel ViewModel = new FromWhoViewModel { Id = FromWho.Id };
                Model.Item1.Add(ViewModel);
            }
            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<FromWhoViewModel>(new FromWhoViewModel());

            //await Service.InsertAsync(new BuildingTypeRegisterDto { });

            return View(Model);
        }

        public IActionResult Update()
        {
            var Model = Tuple.Create<FromWhoViewModel>(new FromWhoViewModel());

            return View(Model);
        }

        public IActionResult Delete()
        {
            var Model = Tuple.Create<FromWhoViewModel>(new FromWhoViewModel());

            return View(Model);
        }
    }
}