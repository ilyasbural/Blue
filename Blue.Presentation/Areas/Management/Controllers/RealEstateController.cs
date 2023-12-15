namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class RealEstateController : Controller
    {
        readonly IRealEstateService Service;
        public RealEstateController(IRealEstateService service)
        {
            Service = service;
        }

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<RealEstateViewModel>> (new List<RealEstateViewModel>());
            Response<RealEstate> RealEstateResponse = await Service.SelectAsync(new RealEstateSelectDto {   });
            foreach (RealEstate RealEstate in RealEstateResponse.Collection)
            {
                RealEstateViewModel ViewModel = new RealEstateViewModel { Id = RealEstate.Id };
                Model.Item1.Add(ViewModel);
            }
            return View(Model);
        }

        public IActionResult Create()
        {
            var Model = Tuple.Create<RealEstateViewModel, RealEstateDetailViewModel> (new RealEstateViewModel(), new RealEstateDetailViewModel());

            //await Service.InsertAsync(new BuildingTypeRegisterDto { });

            return View(Model);
        }

        public IActionResult Update()
        {
            var Model = Tuple.Create<RealEstateViewModel, RealEstateDetailViewModel>(new RealEstateViewModel(), new RealEstateDetailViewModel());

            return View(Model);
        }

        public IActionResult Delete()
        {
            var Model = Tuple.Create<RealEstateViewModel, RealEstateDetailViewModel>(new RealEstateViewModel(), new RealEstateDetailViewModel());

            return View(Model);
        }
    }
}