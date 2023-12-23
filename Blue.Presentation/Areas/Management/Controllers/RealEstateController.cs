namespace Blue.Presentation.Areas.Management.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [Area("Management")]
    public class RealEstateController : Controller
    {
        readonly IBuildingTypeService BuildingTypeService;
        readonly IBuyingTypeService BuyingTypeService;
        readonly ICityService CityService;
        readonly IDistrictService DistrictService;
        readonly IFeaturesAroundService FeaturesAroundService;
        readonly IFeaturesInsideService FeaturesInsideService;
        readonly IFeaturesOutsideService FeaturesOutsideService;
        readonly IFromWhoService FromWhoService;
        readonly IFuelTypeService FuelTypeService;
        readonly IFurnitureService FurnitureService;
        readonly IHometownService HometownService;
        readonly IPriceService PriceService;
		readonly IRealEstateService RealEstateService;
        readonly IRealEstateDetailService RealEstateDetailService;
		readonly IRoomService RoomService;
        readonly ISizeService SizeService;
        readonly IStatusService StatusService;
        readonly ITypeService TypeService;
        readonly IWarmingService WarmingService;

        public RealEstateController
        (
            IBuildingTypeService buildingTypeService, 
            IBuyingTypeService buyingTypeService, 
            ICityService cityService, 
            IDistrictService districtService, 
            IFeaturesAroundService featuresAroundService, 
            IFeaturesInsideService featuresInsideService, 
            IFeaturesOutsideService featuresOutsideService, 
            IFromWhoService fromWhoService, 
            IFuelTypeService fuelTypeService, 
            IFurnitureService furnitureService,
			IHometownService hometownService,
			IPriceService priceService,
			IRealEstateService realEstateService,
            IRealEstateDetailService realEstateDetailService,
			IRoomService roomService, 
            ISizeService sizeService, 
            IStatusService statusService,
            ITypeService typeService,
            IWarmingService warmingService)
        {
            BuildingTypeService = buildingTypeService;
            BuyingTypeService = buyingTypeService;
            CityService = cityService;
            DistrictService = districtService;
            FeaturesAroundService = featuresAroundService;
			FeaturesInsideService = featuresInsideService;
            FeaturesOutsideService = featuresOutsideService;
			FromWhoService = fromWhoService;
            FuelTypeService = fuelTypeService;
			FurnitureService = furnitureService;
			HometownService = hometownService;
            PriceService = priceService;
			RealEstateService = realEstateService;
			RealEstateDetailService = realEstateDetailService;
            RoomService = roomService;
            SizeService = sizeService;
            StatusService = statusService;
            TypeService = typeService;
			WarmingService = warmingService;
		}

        public async Task<IActionResult> Index()
        {
            var Model = Tuple.Create<List<RealEstateViewModel>>(new List<RealEstateViewModel>());
            Response<RealEstate> RealEstateResponse = await RealEstateService.SelectAsync(new RealEstateSelectDto { });
            foreach (RealEstate RealEstate in RealEstateResponse.Collection)
            {
                RealEstateViewModel ViewModel = new RealEstateViewModel { Id = RealEstate.Id, Name = RealEstate.Name };
                Model.Item1.Add(ViewModel);
            }
            return View(Model);
        }

        public async Task<IActionResult> Create()
        {
            var Model = Tuple.Create<RealEstateViewModel, RealEstateDetailViewModel, RealEstateComplexModel>
            (new RealEstateViewModel(), new RealEstateDetailViewModel(), new RealEstateComplexModel());

            Response<BuildingType> BuildingTypeResponse = await BuildingTypeService.SelectAsync(new BuildingTypeSelectDto { });
			await BuyingTypeService.SelectAsync(new BuyingTypeSelectDto { });
            await CityService.SelectAsync(new CitySelectDto { });
            await DistrictService.SelectAsync(new DistrictSelectDto { });
            await FeaturesAroundService.SelectAsync (new FeaturesAroundSelectDto { });
            await FeaturesInsideService.SelectAsync(new FeaturesInsideSelectDto { });
            await FeaturesOutsideService.SelectAsync(new FeaturesOutsideSelectDto { });
            await FromWhoService.SelectAsync(new FromWhoSelectDto { });
            await FuelTypeService.SelectAsync(new FuelTypeSelectDto { });
            await FurnitureService.SelectAsync(new FurnitureSelectDto { });
            await HometownService.SelectAsync(new HometownSelectDto { });
            await PriceService.SelectAsync(new PriceSelectDto { });
            await RoomService.SelectAsync(new RoomSelectDto { });
            await SizeService.SelectAsync(new SizeSelectDto { });
            await StatusService.SelectAsync(new StatusSelectDto { });
            await TypeService.SelectAsync(new TypeSelectDto { });
            await WarmingService.SelectAsync(new WarmingSelectDto { });

            return View(Model);
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind(Prefix = "Item1")] RealEstateViewModel Model)
        {
            RealEstateRegisterDto RealEstate = new RealEstateRegisterDto();
            RealEstate.Name = Model.Name;
            Response<RealEstate> Response = await RealEstateService.InsertAsync(RealEstate);
            if (Response.Success > 0) return RedirectToAction("Index");
            else return View(Model);
        }

        public async Task<IActionResult> Update(Guid Id)
        {
            var Model = Tuple.Create<RealEstateViewModel, RealEstateDetailViewModel>(new RealEstateViewModel(), new RealEstateDetailViewModel());
            Response<RealEstate> Response = await RealEstateService.SelectSingleAsync(new RealEstateSelectDto { Id = Id });

			await BuildingTypeService.SelectAsync(new BuildingTypeSelectDto { });
			await BuyingTypeService.SelectAsync(new BuyingTypeSelectDto { });
			await CityService.SelectAsync(new CitySelectDto { });
			await DistrictService.SelectAsync(new DistrictSelectDto { });
			await FeaturesAroundService.SelectAsync(new FeaturesAroundSelectDto { });
			await FeaturesInsideService.SelectAsync(new FeaturesInsideSelectDto { });
			await FeaturesOutsideService.SelectAsync(new FeaturesOutsideSelectDto { });
			await FromWhoService.SelectAsync(new FromWhoSelectDto { });
			await FuelTypeService.SelectAsync(new FuelTypeSelectDto { });
			await FurnitureService.SelectAsync(new FurnitureSelectDto { });
			await HometownService.SelectAsync(new HometownSelectDto { });
			await PriceService.SelectAsync(new PriceSelectDto { });
			await RoomService.SelectAsync(new RoomSelectDto { });
			await SizeService.SelectAsync(new SizeSelectDto { });
			await StatusService.SelectAsync(new StatusSelectDto { });
			await TypeService.SelectAsync(new TypeSelectDto { });
			await WarmingService.SelectAsync(new WarmingSelectDto { });

			Model.Item1.Id = Response.Collection.First().Id;
            Model.Item1.Name = Response.Collection.First().Name;
            Model.Item1.RegisterDate = Response.Collection.First().RegisterDate;
            Model.Item1.UpdateDate = Response.Collection.First().UpdateDate;

            return View(Model);
        }

		[HttpPost]
		public async Task<IActionResult> Update([Bind(Prefix = "Item1")] RealEstateViewModel Model)
		{
			RealEstateUpdateDto RealEstate = new RealEstateUpdateDto();
            RealEstate.Id = Model.Id;
			RealEstate.Name = Model.Name;
			Response<RealEstate> Response = await RealEstateService.UpdateAsync(RealEstate);
			if (Response.Success > 0) return RedirectToAction("Index");
			else return View(Model);
		}

		public async Task<IActionResult> Delete(Guid Id)
        {
            var Model = Tuple.Create<RealEstateViewModel, RealEstateDetailViewModel>(new RealEstateViewModel(), new RealEstateDetailViewModel());
            Response<RealEstate> Response = await RealEstateService.SelectSingleAsync(new RealEstateSelectDto { Id = Id });

            Model.Item1.Id = Response.Collection.First().Id;
            Model.Item1.Name = Response.Collection.First().Name;
            Model.Item1.RegisterDate = Response.Collection.First().RegisterDate;
            Model.Item1.UpdateDate = Response.Collection.First().UpdateDate;

            return View(Model);
        }

		[HttpPost]
		public async Task<IActionResult> Delete([Bind(Prefix = "Item1")] RealEstateViewModel Model)
		{
			RealEstateDeleteDto RealEstate = new RealEstateDeleteDto();
			RealEstate.Id = Model.Id;
			Response<RealEstate> Response = await RealEstateService.DeleteAsync(RealEstate);
			if (Response.Success > 0) return RedirectToAction("Index");
			else return View(Model);
		}
	}
}