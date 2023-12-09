namespace Blue.DataAccess
{
    using Core;

    public class UnitOfWork : IUnitOfWork
    {
        public ICity City => CityRepository ?? new CityRepositoryEF(DbContext);
        public IDistrict District => DistrictRepository ?? new DistrictRepositoryEF(DbContext);
        public IFurniture Furniture => FurnitureRepository ?? new FurnitureRepositoryEF(DbContext);
        public IManagement Management => ManagementRepository ?? new ManagementRepositoryEF(DbContext);
        public IPicture Picture => PictureRepository ?? new PictureRepositoryEF(DbContext);
        public IPrice Price => PriceRepository ?? new PriceRepositoryEF(DbContext);
        public IRealEstateDetail RealEstateDetail => RealEstateDetailRepository ?? new RealEstateDetailRepositoryEF(DbContext);
        public IRealEstate RealEstate => RealEstateRepository ?? new RealEstateRepositoryEF(DbContext);
        public ISize Size => SizeRepository ?? new SizeRepositoryEF(DbContext);
        public IType Type => TypeRepository ?? new TypeRepositoryEF(DbContext);
        public IWarming Warming => WarmingRepository ?? new WarmingRepositoryEF(DbContext);

        BlueContext DbContext;

        public UnitOfWork(BlueContext dbContext)
        {
            DbContext = dbContext;
        }

        protected BuildingTypeRepositoryEF BuildingTypeRepository { get; set; } = null!;
        protected BuyingTypeRepositoryEF BuyingTypeRepository { get; set; } = null!;
        protected CityRepositoryEF CityRepository { get; set; } = null!;
        protected DistrictRepositoryEF DistrictRepository { get; set; } = null!;
        protected FeaturesAroundRepositoryEF FeaturesAroundRepository { get; set; } = null!;
        protected FeaturesInsideRepositoryEF FeaturesInsideRepository { get; set; } = null!;
        protected FeaturesOutsideRepositoryEF FeaturesOutsideRepository { get; set; } = null!;
        protected FromWhoRepositoryEF FromWhoRepository { get; set; } = null!;
        protected FuelTypeRepositoryEF FuelTypeRepository { get; set; } = null!;
        protected FurnitureRepositoryEF FurnitureRepository { get; set; } = null!;
        protected HometownRepositoryEF HometownRepository { get; set; } = null!;
        protected ManagementRepositoryEF ManagementRepository { get; set; } = null!;
        protected PictureRepositoryEF PictureRepository { get; set; } = null!;
        protected PriceRepositoryEF PriceRepository { get; set; } = null!;
        protected RealEstateDetailRepositoryEF RealEstateDetailRepository { get; set; } = null!;
        protected RealEstateRepositoryEF RealEstateRepository { get; set; } = null!;
        protected RoomRepositoryEF RoomRepository { get; set; } = null!;
        protected SizeRepositoryEF SizeRepository { get; set; } = null!;
        protected StatusRepositoryEF StatusRepository { get; set; } = null!;
        protected TypeRepositoryEF TypeRepository { get; set; } = null!;
        protected WarmingRepositoryEF WarmingRepository { get; set; } = null!;

        public async Task<int> SaveChangesAsync()
        {
            return await DbContext.SaveChangesAsync();
        }

        public async void Dispose()
        {
            await DbContext.DisposeAsync();
        }
    }
}