namespace Blue.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;

    public partial class BlueContext : DbContext
    {
        public BlueContext() { }
        public BlueContext(DbContextOptions<BlueContext> options) : base(options) { }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Furniture> Furnitures { get; set; }
        public virtual DbSet<Management> Managements { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
        public virtual DbSet<RealEstate> RealEstates { get; set; }
        public virtual DbSet<RealEstateDetail> RealEstateDetails { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
        public virtual DbSet<Type> Types { get; set; }
        public virtual DbSet<Warming> Warmings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-LUSNRB7; Database=BLUE; Trusted_Connection=True; TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("CITY");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("date")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("date")
                    .HasColumnName("UPDATE DATE");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.ToTable("DISTRICT");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.City).HasColumnName("CITY");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("date")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("date")
                    .HasColumnName("UPDATE DATE");

                entity.HasOne(d => d.CityNavigation).WithMany(p => p.Districts)
                    .HasForeignKey(d => d.City)
                    .HasConstraintName("FK_DISTRICT_CITY");
            });

            modelBuilder.Entity<Furniture>(entity =>
            {
                entity.ToTable("FURNITURE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("date")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("date")
                    .HasColumnName("UPDATE DATE");
            });

            modelBuilder.Entity<Management>(entity =>
            {
                entity.ToTable("MANAGEMENT");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("PASSWORD");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("date")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("date")
                    .HasColumnName("UPDATE DATE");
            });

            modelBuilder.Entity<Picture>(entity =>
            {
                entity.ToTable("PICTURE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("date")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("date")
                    .HasColumnName("UPDATE DATE");
            });

            modelBuilder.Entity<Price>(entity =>
            {
                entity.ToTable("PRICE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("date")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("date")
                    .HasColumnName("UPDATE DATE");
            });

            modelBuilder.Entity<RealEstate>(entity =>
            {
                entity.ToTable("REAL ESTATE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.City).HasColumnName("CITY");
                entity.Property(e => e.District).HasColumnName("DISTRICT");
                entity.Property(e => e.Furniture).HasColumnName("FURNITURE");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.Price).HasColumnName("PRICE");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.Size).HasColumnName("SIZE");
                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("TITLE");
                entity.Property(e => e.Type).HasColumnName("TYPE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE DATE");
                entity.Property(e => e.Warming).HasColumnName("WARMING");

                entity.HasOne(d => d.CityNavigation).WithMany(p => p.RealEstates)
                    .HasForeignKey(d => d.City)
                    .HasConstraintName("FK_REAL ESTATE_CITY");

                entity.HasOne(d => d.DistrictNavigation).WithMany(p => p.RealEstates)
                    .HasForeignKey(d => d.District)
                    .HasConstraintName("FK_REAL ESTATE_DISTRICT");

                entity.HasOne(d => d.FurnitureNavigation).WithMany(p => p.RealEstates)
                    .HasForeignKey(d => d.Furniture)
                    .HasConstraintName("FK_REAL ESTATE_FURNITURE");

                entity.HasOne(d => d.PriceNavigation).WithMany(p => p.RealEstates)
                    .HasForeignKey(d => d.Price)
                    .HasConstraintName("FK_REAL ESTATE_PRICE");

                entity.HasOne(d => d.SizeNavigation).WithMany(p => p.RealEstates)
                    .HasForeignKey(d => d.Size)
                    .HasConstraintName("FK_REAL ESTATE_SIZE");

                entity.HasOne(d => d.TypeNavigation).WithMany(p => p.RealEstates)
                    .HasForeignKey(d => d.Type)
                    .HasConstraintName("FK_REAL ESTATE_REAL ESTATE TYPE");

                entity.HasOne(d => d.WarmingNavigation).WithMany(p => p.RealEstates)
                    .HasForeignKey(d => d.Warming)
                    .HasConstraintName("FK_REAL ESTATE_WARMING");
            });

            modelBuilder.Entity<RealEstateDetail>(entity =>
            {
                entity.ToTable("REAL ESTATE DETAIL");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("DESCRIPTION");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("date")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("date")
                    .HasColumnName("UPDATE DATE");

                entity.HasOne(d => d.IdNavigation).WithOne(p => p.RealEstateDetail)
                    .HasForeignKey<RealEstateDetail>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REAL ESTATE DETAIL_REAL ESTATE");
            });

            modelBuilder.Entity<Size>(entity =>
            {
                entity.ToTable("SIZE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("date")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("date")
                    .HasColumnName("UPDATE DATE");
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK_REAL ESTATE TYPE");

                entity.ToTable("TYPE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE DATE");
            });

            modelBuilder.Entity<Warming>(entity =>
            {
                entity.ToTable("WARMING");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("date")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("date")
                    .HasColumnName("UPDATE DATE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}