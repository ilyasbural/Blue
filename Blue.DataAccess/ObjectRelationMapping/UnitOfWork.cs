namespace Blue.DataAccess
{
    using Core;

    public class UnitOfWork : IUnitOfWork
    {
        BlueContext DbContext;

        public ICityRepository City => CityRepository ?? new CityRepositoryEF(DbContext);
        public IDistrictRepository District => DistrictRepository ?? new DistrictRepositoryEF(DbContext);
        public IFurnitureRepository Furniture => FurnitureRepository ?? new FurnitureRepositoryEF(DbContext);
        public IManagementRepository Management => ManagementRepository ?? new ManagementRepositoryEF(DbContext);
        public IPictureRepository Picture => PictureRepository ?? new PictureRepositoryEF(DbContext);
        public IPriceRepository Price => PriceRepository ?? new PriceRepositoryEF(DbContext);
        public IRealEstateDetailRepository RealEstateDetail => RealEstateDetailRepository ?? new RealEstateDetailRepositoryEF(DbContext);
        public IRealEstateRepository RealEstate => RealEstateRepository ?? new RealEstateRepositoryEF(DbContext);
        public ISizeRepository Size => SizeRepository ?? new SizeRepositoryEF(DbContext);
        public ITypeRepository Type => TypeRepository ?? new TypeRepositoryEF(DbContext);
        public IWarmingRepository Warming => WarmingRepository ?? new WarmingRepositoryEF(DbContext);

        public UnitOfWork(BlueContext dbContext)
        {
            DbContext = dbContext;
        }

        protected CityRepositoryEF CityRepository { get; set; } = null!;
        protected DistrictRepositoryEF DistrictRepository { get; set; } = null!;
        protected FurnitureRepositoryEF FurnitureRepository { get; set; } = null!;
        protected ManagementRepositoryEF ManagementRepository { get; set; } = null!;
        protected PictureRepositoryEF PictureRepository { get; set; } = null!;
        protected PriceRepositoryEF PriceRepository { get; set; } = null!;
        protected RealEstateDetailRepositoryEF RealEstateDetailRepository { get; set; } = null!;
        protected RealEstateRepositoryEF RealEstateRepository { get; set; } = null!;
        protected SizeRepositoryEF SizeRepository { get; set; } = null!;
        protected TypeRepositoryEF TypeRepository { get; set; } = null!;
        protected WarmingRepositoryEF WarmingRepository { get; set; } = null!;

        public async Task<int> SaveChangesAsync()
        {
            return await DbContext.SaveChangesAsync();
        }
    }
}