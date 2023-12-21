namespace Blue.DataAccess
{
    using Core;

    public class UnitOfWork : IUnitOfWork
    {
        public IBuildingType BuildingType => BuildingTypeRepository ?? new BuildingTypeRepositoryEF(DbContext);
        public IBuyingType BuyingType => BuyingTypeRepository ?? new BuyingTypeRepositoryEF(DbContext);
        public ICity City => CityRepository ?? new CityRepositoryEF(DbContext);
        public IDistrict District => DistrictRepository ?? new DistrictRepositoryEF(DbContext);
        public IFeaturesAround FeaturesAround => FeaturesAroundRepository ?? new FeaturesAroundRepositoryEF(DbContext);
        public IFeaturesInside FeaturesInside => FeaturesInsideRepository ?? new FeaturesInsideRepositoryEF(DbContext);
        public IFeaturesOutside FeaturesOutside => FeaturesOutsideRepository ?? new FeaturesOutsideRepositoryEF(DbContext);
        public IFromWho FromWho => FromWhoRepository ?? new FromWhoRepositoryEF(DbContext);
        public IFuelType FuelType => FuelTypeRepository ?? new FuelTypeRepositoryEF(DbContext);
        public IFurniture Furniture => FurnitureRepository ?? new FurnitureRepositoryEF(DbContext);
        public IHometown Hometown => HometownRepository ?? new HometownRepositoryEF(DbContext);
        public IManagement Management => ManagementRepository ?? new ManagementRepositoryEF(DbContext);
        public IPicture Picture => PictureRepository ?? new PictureRepositoryEF(DbContext);
        public IPrice Price => PriceRepository ?? new PriceRepositoryEF(DbContext);
        public IRealEstateDetail RealEstateDetail => RealEstateDetailRepository ?? new RealEstateDetailRepositoryEF(DbContext);
        public IRealEstate RealEstate => RealEstateRepository ?? new RealEstateRepositoryEF(DbContext);
        public IRoom Room => RoomRepository ?? new RoomRepositoryEF(DbContext);
        public ISize Size => SizeRepository ?? new SizeRepositoryEF(DbContext);
        public IStatus Status => StatusRepository ?? new StatusRepositoryEF(DbContext);
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