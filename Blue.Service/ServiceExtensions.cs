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

            Service.AddScoped<IValidator<City>, CityValidator>();
            Service.AddScoped<IValidator<District>, DistrictValidator>();
            Service.AddScoped<IValidator<Furniture>, FurnitureValidator>();
            Service.AddScoped<IValidator<Management>, ManagementValidator>();
            Service.AddScoped<IValidator<Picture>, PictureValidator>();
            Service.AddScoped<IValidator<Price>, PriceValidator>();
            Service.AddScoped<IValidator<RealEstateDetail>, RealEstateDetailValidator>();
            Service.AddScoped<IValidator<RealEstate>, RealEstateValidator>();
            Service.AddScoped<IValidator<Size>, SizeValidator>();
            Service.AddScoped<IValidator<Type>, TypeValidator>();
            Service.AddScoped<IValidator<Warming>, WarmingValidator>();

            Service.AddScoped<ICityService, CityManager>();
            Service.AddScoped<IDistrictService, DistrictManager>();
            Service.AddScoped<IFurnitureService, FurnitureManager>();
            Service.AddScoped<IManagementService, ManagementManager>();
            Service.AddScoped<IPictureService, PictureManager>();
            Service.AddScoped<IPriceService, PriceManager>();
            Service.AddScoped<IRealEstateDetailService, RealEstateDetailManager>();
            Service.AddScoped<IRealEstateService, RealEstateManager>();
            Service.AddScoped<ISizeService, SizeManager>();
            Service.AddScoped<ITypeService, TypeManager>();
            Service.AddScoped<IWarmingService, WarmingManager>();

            return Service;
        }
    }
}