namespace Blue.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ICity City { get; }
        IDistrict District { get; }
        IFurniture Furniture { get; }
        IManagement Management { get; }
        IPicture Picture { get; }
        IPrice Price { get; }
        IRealEstateDetail RealEstateDetail { get; }
        IRealEstate RealEstate { get; }
        ISize Size { get; }
        IType Type { get; }
        IWarming Warming { get; }
        Task<int> SaveChangesAsync();
    }
}