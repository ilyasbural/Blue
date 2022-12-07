namespace Blue.Core
{
    public interface IUnitOfWork
    {
        ICityRepository City { get; }
        IDistrictRepository District { get; }
        IFurnitureRepository Furniture { get; }
        IManagementRepository Management { get; }
        IPictureRepository Picture { get; }
        IPriceRepository Price { get; }
        IRealEstateDetailRepository RealEstateDetail { get; }
        IRealEstateRepository RealEstate { get; }
        ISizeRepository Size { get; }
        ITypeRepository Type { get; }
        IWarmingRepository Warming { get; }
        Task<int> SaveChangesAsync();
    }
}