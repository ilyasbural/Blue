namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class ManagementController : Controller
    {
        readonly IManagementService Service;
        public ManagementController(IManagementService service)
        {
            Service = service;
        }

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<ManagementViewModel>> (new List<ManagementViewModel>());
            Response<Management> ManagementResponse = await Service.SelectAsync(new ManagementSelectDto {    });
            foreach (Management Management in ManagementResponse.Collection)
            {
                ManagementViewModel ViewModel = new ManagementViewModel { Id = Management.Id };
                Model.Item1.Add(ViewModel);
            }
            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<ManagementViewModel>(new ManagementViewModel());

            //await Service.InsertAsync(new BuildingTypeRegisterDto { });

            return View(Model);
        }

		[HttpPost]
		public async Task<IActionResult> Create([Bind(Prefix = "Item1")] ManagementViewModel Model)
		{
			ManagementRegisterDto Management = new ManagementRegisterDto();
			//BuildingType.Name = Model.Name;
			Response<Management> ManagementResponse = await Service.InsertAsync(Management);
			if (ManagementResponse.Success > 0) return RedirectToAction("Index");
			else return View(Model);
		}

		public IActionResult Update()
        {
            var Model = Tuple.Create<ManagementViewModel>(new ManagementViewModel());

            return View(Model);
        }

        public IActionResult Delete()
        {
            var Model = Tuple.Create<ManagementViewModel>(new ManagementViewModel());

            return View(Model);
        }
    }
}