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
            var Model = Tuple.Create<List<ManagementViewModel>>(new List<ManagementViewModel>());
            Response<Management> ManagementResponse = await Service.SelectAsync(new ManagementSelectDto { });
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
            return View(Model);
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind(Prefix = "Item1")] ManagementViewModel Model)
        {
            ManagementRegisterDto Management = new ManagementRegisterDto();
            Management.Name = Model.Name;
            Response<Management> Response = await Service.InsertAsync(Management);
            if (Response.Success > 0) return RedirectToAction("Index");
            else return View(Model);
        }

        public IActionResult Update(Guid Id)
        {
            var Model = Tuple.Create<ManagementViewModel>(new ManagementViewModel());

            //Model.Item1.Id = Response.Collection.First().Id;
            //Model.Item1.Name = Response.Collection.First().Name;
            //Model.Item1.RegisterDate = Response.Collection.First().RegisterDate;
            //Model.Item1.UpdateDate = Response.Collection.First().UpdateDate;

            return View(Model);
        }

        public IActionResult Delete(Guid Id)
        {
            var Model = Tuple.Create<ManagementViewModel>(new ManagementViewModel());
            return View(Model);
        }
    }
}