namespace Blue.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IBuildingType BuildingType { get; }
        IBuyingType BuyingType { get; }
        ICity City { get; }
        IDistrict District { get; }
        IFeaturesAround FeaturesAround { get; }
        IFeaturesInside FeaturesInside { get; }
        IFeaturesOutside FeaturesOutside { get; }
        IFromWho FromWho { get; }
        IFuelType FuelType { get; }
        IFurniture Furniture { get; }
        IHometown Hometown { get; }
        IManagement Management { get; }
        IPicture Picture { get; }
        IPrice Price { get; }
        IRealEstateDetail RealEstateDetail { get; }
        IRealEstate RealEstate { get; }
        IRoom Room { get; }
        ISize Size { get; }
        IStatus Status { get; }
        IType Type { get; }
        IWarming Warming { get; }
        Task<int> SaveChangesAsync();
    }
}