namespace Blue.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;

    public class BlueContext : DbContext
    {
        public BlueContext() { }
        public BlueContext(DbContextOptions<BlueContext> options) : base(options) { }

        public virtual DbSet<BuildingType> BuildingTypes { get; set; }
        public virtual DbSet<BuyingType> BuyingTypes { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<FeaturesAround> FeaturesArounds { get; set; }
        public virtual DbSet<FeaturesInside> FeaturesInsides { get; set; }
        public virtual DbSet<FeaturesOutside> FeaturesOutsides { get; set; }
        public virtual DbSet<FromWho> FromWhos { get; set; }
        public virtual DbSet<FuelType> FuelTypes { get; set; }
        public virtual DbSet<Furniture> Furnitures { get; set; }
        public virtual DbSet<Hometown> Hometowns { get; set; }
        public virtual DbSet<Management> Managements { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
        public virtual DbSet<RealEstate> RealEstates { get; set; }
        public virtual DbSet<RealEstateDetail> RealEstateDetails { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Type> Types { get; set; }
        public virtual DbSet<Warming> Warmings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=NATILUS; Database=BLUE;  User Id = sa; Password = Fenerbahce2932; TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BuildingTypeMapping());
            modelBuilder.ApplyConfiguration(new BuyingTypeMapping());
            modelBuilder.ApplyConfiguration(new FeaturesAroundMapping());
            modelBuilder.ApplyConfiguration(new FeaturesInsideMapping());
            modelBuilder.ApplyConfiguration(new FeaturesOutsideMapping());
            modelBuilder.ApplyConfiguration(new FromWhoMapping());
            modelBuilder.ApplyConfiguration(new FuelTypeMapping());
            modelBuilder.ApplyConfiguration(new HometownMapping());
            modelBuilder.ApplyConfiguration(new RoomMapping());
            modelBuilder.ApplyConfiguration(new StatusMapping());
            modelBuilder.ApplyConfiguration(new CityMapping());
            modelBuilder.ApplyConfiguration(new DistrictMapping());
            modelBuilder.ApplyConfiguration(new FurnitureMapping());
            modelBuilder.ApplyConfiguration(new ManagementMapping());
            modelBuilder.ApplyConfiguration(new PictureMapping());
            modelBuilder.ApplyConfiguration(new PriceMapping());
            modelBuilder.ApplyConfiguration(new RealEstateDetailMapping());
            modelBuilder.ApplyConfiguration(new RealEstateMapping());
            modelBuilder.ApplyConfiguration(new SizeMapping());
            modelBuilder.ApplyConfiguration(new TypeMapping());
            modelBuilder.ApplyConfiguration(new WarmingMapping());
        }
    }
}