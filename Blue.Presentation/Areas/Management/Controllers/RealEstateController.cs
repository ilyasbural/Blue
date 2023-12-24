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
            Response<BuyingType> BuyingTypeResponse = await BuyingTypeService.SelectAsync(new BuyingTypeSelectDto { });
            Response<City> CityResponse = await CityService.SelectAsync(new CitySelectDto { });
            Response<District> DistrictResponse = await DistrictService.SelectAsync(new DistrictSelectDto { });
            Response<FeaturesAround> FeaturesAroundResponse = await FeaturesAroundService.SelectAsync(new FeaturesAroundSelectDto { });
            Response<FeaturesInside> FeaturesInsideResponse = await FeaturesInsideService.SelectAsync(new FeaturesInsideSelectDto { });
            Response<FeaturesOutside> FeaturesOutsideResponse = await FeaturesOutsideService.SelectAsync(new FeaturesOutsideSelectDto { });
            Response<FromWho> FromWhoResponse = await FromWhoService.SelectAsync(new FromWhoSelectDto { });
            Response<FuelType> FuelTypeResponse = await FuelTypeService.SelectAsync(new FuelTypeSelectDto { });
            Response<Furniture> FurnitureResponse = await FurnitureService.SelectAsync(new FurnitureSelectDto { });
            Response<Hometown> HometownResponse = await HometownService.SelectAsync(new HometownSelectDto { });
            Response<Price> PriceResponse = await PriceService.SelectAsync(new PriceSelectDto { });
            Response<Room> RoomResponse = await RoomService.SelectAsync(new RoomSelectDto { });
            Response<Size> SizeResponse = await SizeService.SelectAsync(new SizeSelectDto { });
            Response<Status> StatusResponse = await StatusService.SelectAsync(new StatusSelectDto { });
            Response<Type> TypeResponse = await TypeService.SelectAsync(new TypeSelectDto { });
            Response<Warming> WarmingResponse = await WarmingService.SelectAsync(new WarmingSelectDto { });

            Model.Item3.BuildingTypeDataSource = BuildingTypeResponse.Collection;
            Model.Item3.BuyingTypeDataSource = BuyingTypeResponse.Collection;
            Model.Item3.CityDataSource = CityResponse.Collection;
            Model.Item3.DistrictDataSource = DistrictResponse.Collection;
            Model.Item3.FeaturesAroundDataSource = FeaturesAroundResponse.Collection;
            Model.Item3.FeaturesInsideDataSource = FeaturesInsideResponse.Collection;
            Model.Item3.FeaturesOutsideDataSource = FeaturesOutsideResponse.Collection;
            Model.Item3.FromWhoDataSource = FromWhoResponse.Collection;
            Model.Item3.FuelTypeDataSource = FuelTypeResponse.Collection;
            Model.Item3.FurnitureDataSource = FurnitureResponse.Collection;
            Model.Item3.HometownDataSource = HometownResponse.Collection;
            Model.Item3.PriceDataSource = PriceResponse.Collection;
            Model.Item3.RoomDataSource = RoomResponse.Collection;
            Model.Item3.SizeDataSource = SizeResponse.Collection;
            Model.Item3.StatusDataSource = StatusResponse.Collection;
            Model.Item3.TypeDataSource = TypeResponse.Collection;
            Model.Item3.WarmingDataSource = WarmingResponse.Collection;

            return View(Model);
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind(Prefix = "Item1")] RealEstateViewModel Model)
        {
            RealEstateRegisterDto RealEstate = new RealEstateRegisterDto();
            RealEstate.BuildingType = Model.BuildingTypeViewModel.Id;
            RealEstate.BuyingType = Model.BuyingTypeViewModel.Id;
            RealEstate.City = Model.CityViewModel.Id;
            RealEstate.District = Model.DistrictViewModel.Id;
            RealEstate.FeaturesAround = Model.FeaturesAroundViewModel.Id;
            RealEstate.FeaturesInside = Model.FeaturesInsideViewModel.Id;
            RealEstate.FeaturesOutside = Model.FeaturesOutsideViewModel.Id;
            RealEstate.FromWho = Model.FromWhoViewModel.Id;
            RealEstate.FuelType = Model.FuelTypeViewModel.Id;
            RealEstate.Furniture = Model.FurnitureViewModel.Id;
            RealEstate.Hometown = Model.HometownViewModel.Id;
            RealEstate.Price = Model.PriceViewModel.Id;
            RealEstate.Room = Model.RoomViewModel.Id;
            RealEstate.Size = Model.SizeViewModel.Id;
            RealEstate.Status = Model.StatusViewModel.Id;
            RealEstate.Type = Model.TypeViewModel.Id;
            RealEstate.Warming = Model.WarmingViewModel.Id;
            RealEstate.Name = Model.Name;
            Response<RealEstate> Response = await RealEstateService.InsertAsync(RealEstate);
            if (Response.Success > 0) return RedirectToAction("Index");
            else return View(Model);
        }

        public async Task<IActionResult> Update(Guid Id)
        {
            var Model = Tuple.Create<RealEstateViewModel, RealEstateDetailViewModel, RealEstateComplexModel>
            (new RealEstateViewModel(), new RealEstateDetailViewModel(), new RealEstateComplexModel());

            Response<RealEstate> Response = await RealEstateService.SelectSingleAsync(new RealEstateSelectDto { Id = Id });
            Response<BuildingType> BuildingTypeResponse = await BuildingTypeService.SelectAsync(new BuildingTypeSelectDto { });
            Response<BuyingType> BuyingTypeResponse = await BuyingTypeService.SelectAsync(new BuyingTypeSelectDto { });
            Response<City> CityResponse = await CityService.SelectAsync(new CitySelectDto { });
            Response<District> DistrictResponse = await DistrictService.SelectAsync(new DistrictSelectDto { });
            Response<FeaturesAround> FeaturesAroundResponse = await FeaturesAroundService.SelectAsync(new FeaturesAroundSelectDto { });
            Response<FeaturesInside> FeaturesInsideResponse = await FeaturesInsideService.SelectAsync(new FeaturesInsideSelectDto { });
            Response<FeaturesOutside> FeaturesOutsideResponse = await FeaturesOutsideService.SelectAsync(new FeaturesOutsideSelectDto { });
            Response<FromWho> FromWhoResponse = await FromWhoService.SelectAsync(new FromWhoSelectDto { });
            Response<FuelType> FuelTypeResponse = await FuelTypeService.SelectAsync(new FuelTypeSelectDto { });
            Response<Furniture> FurnitureResponse = await FurnitureService.SelectAsync(new FurnitureSelectDto { });
            Response<Hometown> HometownResponse = await HometownService.SelectAsync(new HometownSelectDto { });
            Response<Price> PriceResponse = await PriceService.SelectAsync(new PriceSelectDto { });
            Response<Room> RoomResponse = await RoomService.SelectAsync(new RoomSelectDto { });
            Response<Size> SizeResponse = await SizeService.SelectAsync(new SizeSelectDto { });
            Response<Status> StatusResponse = await StatusService.SelectAsync(new StatusSelectDto { });
            Response<Type> TypeResponse = await TypeService.SelectAsync(new TypeSelectDto { });
            Response<Warming> WarmingResponse = await WarmingService.SelectAsync(new WarmingSelectDto { });

            Model.Item3.BuildingTypeDataSource = BuildingTypeResponse.Collection;
            Model.Item3.BuyingTypeDataSource = BuyingTypeResponse.Collection;
            Model.Item3.CityDataSource = CityResponse.Collection;
            Model.Item3.DistrictDataSource = DistrictResponse.Collection;
            Model.Item3.FeaturesAroundDataSource = FeaturesAroundResponse.Collection;
            Model.Item3.FeaturesInsideDataSource = FeaturesInsideResponse.Collection;
            Model.Item3.FeaturesOutsideDataSource = FeaturesOutsideResponse.Collection;
            Model.Item3.FromWhoDataSource = FromWhoResponse.Collection;
            Model.Item3.FuelTypeDataSource = FuelTypeResponse.Collection;
            Model.Item3.FurnitureDataSource = FurnitureResponse.Collection;
            Model.Item3.HometownDataSource = HometownResponse.Collection;
            Model.Item3.PriceDataSource = PriceResponse.Collection;
            Model.Item3.RoomDataSource = RoomResponse.Collection;
            Model.Item3.SizeDataSource = SizeResponse.Collection;
            Model.Item3.StatusDataSource = StatusResponse.Collection;
            Model.Item3.TypeDataSource = TypeResponse.Collection;
            Model.Item3.WarmingDataSource = WarmingResponse.Collection;

            Model.Item1.BuildingTypeViewModel.Id = Response.Collection.First().BuildingType.Id;
            Model.Item1.BuyingTypeViewModel.Id = Response.Collection.First().BuyingType.Id;
            Model.Item1.CityViewModel.Id = Response.Collection.First().City.Id;
            Model.Item1.DistrictViewModel.Id = Response.Collection.First().District.Id;
            Model.Item1.FeaturesAroundViewModel.Id = Response.Collection.First().FeaturesAround.Id;
            Model.Item1.FeaturesInsideViewModel.Id = Response.Collection.First().FeaturesInside.Id;
            Model.Item1.FeaturesOutsideViewModel.Id = Response.Collection.First().FeaturesOutside.Id;
            Model.Item1.FromWhoViewModel.Id = Response.Collection.First().FromWho.Id;
            Model.Item1.FuelTypeViewModel.Id = Response.Collection.First().FuelType.Id;
            Model.Item1.FurnitureViewModel.Id = Response.Collection.First().Furniture.Id;
            Model.Item1.HometownViewModel.Id = Response.Collection.First().Hometown.Id;
            Model.Item1.PriceViewModel.Id = Response.Collection.First().Price.Id;
            Model.Item1.RoomViewModel.Id = Response.Collection.First().Room.Id;
            Model.Item1.SizeViewModel.Id = Response.Collection.First().Size.Id;
            Model.Item1.StatusViewModel.Id = Response.Collection.First().Status.Id;
            Model.Item1.TypeViewModel.Id = Response.Collection.First().Type.Id;
            Model.Item1.WarmingViewModel.Id = Response.Collection.First().Warming.Id;
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
            RealEstate.BuildingType = Model.BuildingTypeViewModel.Id;
            RealEstate.BuyingType = Model.BuyingTypeViewModel.Id;
            RealEstate.City = Model.CityViewModel.Id;
            RealEstate.District = Model.DistrictViewModel.Id;
            RealEstate.FeaturesAround = Model.FeaturesAroundViewModel.Id;
            RealEstate.FeaturesInside = Model.FeaturesInsideViewModel.Id;
            RealEstate.FeaturesOutside = Model.FeaturesOutsideViewModel.Id;
            RealEstate.FromWho = Model.FromWhoViewModel.Id;
            RealEstate.FuelType = Model.FuelTypeViewModel.Id;
            RealEstate.Furniture = Model.FurnitureViewModel.Id;
            RealEstate.Hometown = Model.HometownViewModel.Id;
            RealEstate.Price = Model.PriceViewModel.Id;
            RealEstate.Room = Model.RoomViewModel.Id;
            RealEstate.Size = Model.SizeViewModel.Id;
            RealEstate.Status = Model.StatusViewModel.Id;
            RealEstate.Type = Model.TypeViewModel.Id;
            RealEstate.Warming = Model.WarmingViewModel.Id;
            RealEstate.Id = Model.Id;
            RealEstate.Name = Model.Name;
            RealEstate.UpdateDate = DateTime.Now;
            Response<RealEstate> Response = await RealEstateService.UpdateAsync(RealEstate);
            if (Response.Success > 0) return RedirectToAction("Index");
            else return View(Model);
        }

        public async Task<IActionResult> Delete(Guid Id)
        {
            var Model = Tuple.Create<RealEstateViewModel, RealEstateDetailViewModel>
            (new RealEstateViewModel(), new RealEstateDetailViewModel());
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