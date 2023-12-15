namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class HometownController : Controller
    {
        readonly IHometownService Service;
        public HometownController(IHometownService service)
        {
            Service = service;
        }

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<HometownViewModel>> (new List<HometownViewModel>());
            Response<Hometown> HometownResponse = await Service.SelectAsync(new HometownSelectDto {     });
            foreach (Hometown Hometown in HometownResponse.Collection)
            {
                HometownViewModel ViewModel = new HometownViewModel { Id = Hometown.Id };
                Model.Item1.Add(ViewModel);
            }
            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<HometownViewModel>(new HometownViewModel());

            //await Service.InsertAsync(new BuildingTypeRegisterDto { });

            return View(Model);
        }

		[HttpPost]
		public async Task<IActionResult> Create([Bind(Prefix = "Item1")] HometownViewModel Model)
		{
			HometownRegisterDto Hometown = new HometownRegisterDto();
			//BuildingType.Name = Model.Name;
			Response<Hometown> HometownResponse = await Service.InsertAsync(Hometown);
			if (HometownResponse.Success > 0) return RedirectToAction("Index");
			else return View(Model);
		}

		public IActionResult Update()
        {
            var Model = Tuple.Create<HometownViewModel>(new HometownViewModel());

            return View(Model);
        }

        public IActionResult Delete()
        {
            var Model = Tuple.Create<HometownViewModel>(new HometownViewModel());

            return View(Model);
        }
    }
}