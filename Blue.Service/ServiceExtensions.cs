namespace Blue.Service
{
	using Core;
	using DataAccess;
	using FluentValidation;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.Extensions.DependencyInjection;

	public static class ServiceExtensions
	{
		public static IServiceCollection LoadServices(this IServiceCollection Service)
		{
			Service.AddDbContext<DbContext>();
			Service.AddDbContext<BlueContext>();

			Service.AddScoped<IBuildingType, BuildingTypeRepositoryEF>();
			Service.AddScoped<IBuyingType, BuyingTypeRepositoryEF>();
			Service.AddScoped<ICity, CityRepositoryEF>();
			Service.AddScoped<IDistrict, DistrictRepositoryEF>();
			Service.AddScoped<IFeaturesAround, FeaturesAroundRepositoryEF>();
			Service.AddScoped<IFeaturesInside, FeaturesInsideRepositoryEF>();
			Service.AddScoped<IFeaturesOutside, FeaturesOutsideRepositoryEF>();
			Service.AddScoped<IFromWho, FromWhoRepositoryEF>();
			Service.AddScoped<IFuelType, FuelTypeRepositoryEF>();
			Service.AddScoped<IFurniture, FurnitureRepositoryEF>();
			Service.AddScoped<IHometown, HometownRepositoryEF>();
			Service.AddScoped<IManagement, ManagementRepositoryEF>();
			Service.AddScoped<IPicture, PictureRepositoryEF>();
			Service.AddScoped<IPrice, PriceRepositoryEF>();
			Service.AddScoped<IRealEstateDetail, RealEstateDetailRepositoryEF>();
			Service.AddScoped<IRealEstate, RealEstateRepositoryEF>();
			Service.AddScoped<IRoom, RoomRepositoryEF>();
			Service.AddScoped<ISize, SizeRepositoryEF>();
			Service.AddScoped<IStatus, StatusRepositoryEF>();
			Service.AddScoped<IType, TypeRepositoryEF>();
			Service.AddScoped<IWarming, WarmingRepositoryEF>();
			Service.AddScoped<IUnitOfWork, UnitOfWork>();

			Service.AddScoped<IValidator<BuildingType>, BuildingTypeValidator>();
			Service.AddScoped<IValidator<BuyingType>, BuyingTypeValidator>();
			Service.AddScoped<IValidator<City>, CityValidator>();
			Service.AddScoped<IValidator<District>, DistrictValidator>();
			Service.AddScoped<IValidator<FeaturesAround>, FeaturesAroundValidator>();
			Service.AddScoped<IValidator<FeaturesInside>, FeaturesInsideValidator>();
			Service.AddScoped<IValidator<FeaturesOutside>, FeaturesOutsideValidator>();
			Service.AddScoped<IValidator<FromWho>, FromWhoValidator>();
			Service.AddScoped<IValidator<FuelType>, FuelTypeValidator>();
			Service.AddScoped<IValidator<Furniture>, FurnitureValidator>();
			Service.AddScoped<IValidator<Hometown>, HometownValidator>();
			Service.AddScoped<IValidator<Management>, ManagementValidator>();
			Service.AddScoped<IValidator<Picture>, PictureValidator>();
			Service.AddScoped<IValidator<Price>, PriceValidator>();
			Service.AddScoped<IValidator<RealEstateDetail>, RealEstateDetailValidator>();
			Service.AddScoped<IValidator<RealEstate>, RealEstateValidator>();
			Service.AddScoped<IValidator<Room>, RoomValidator>();
			Service.AddScoped<IValidator<Size>, SizeValidator>();
			Service.AddScoped<IValidator<Status>, StatusValidator>();
			Service.AddScoped<IValidator<Type>, TypeValidator>();
			Service.AddScoped<IValidator<Warming>, WarmingValidator>();

			Service.AddScoped<IBuildingTypeService, BuildingTypeManager>();
			Service.AddScoped<IBuyingTypeService, BuyingTypeManager>();
			Service.AddScoped<ICityService, CityManager>();
			Service.AddScoped<IDistrictService, DistrictManager>();
			Service.AddScoped<IFeaturesAroundService, FeaturesAroundManager>();
			Service.AddScoped<IFeaturesInsideService, FeaturesInsideManager>();
			Service.AddScoped<IFeaturesOutsideService, FeaturesOutsideManager>();
			Service.AddScoped<IFromWhoService, FromWhoManager>();
			Service.AddScoped<IFuelTypeService, FuelTypeManager>();
			Service.AddScoped<IFurnitureService, FurnitureManager>();
			Service.AddScoped<IHometownService, HometownManager>();
			Service.AddScoped<IManagementService, ManagementManager>();
			Service.AddScoped<IPictureService, PictureManager>();
			Service.AddScoped<IPriceService, PriceManager>();
			Service.AddScoped<IRealEstateDetailService, RealEstateDetailManager>();
			Service.AddScoped<IRealEstateService, RealEstateManager>();
			Service.AddScoped<IRoomService, RoomManager>();
			Service.AddScoped<ISizeService, SizeManager>();
			Service.AddScoped<IStatusService, StatusManager>();
			Service.AddScoped<ITypeService, TypeManager>();
			Service.AddScoped<IWarmingService, WarmingManager>();

			return Service;
		}
	}
}