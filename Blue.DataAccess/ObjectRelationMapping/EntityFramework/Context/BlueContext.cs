namespace Blue.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;

    public partial class BlueContext : DbContext
    {
        public BlueContext() { }
        public BlueContext(DbContextOptions<BlueContext> options) : base(options) { }

        public virtual DbSet<Management> Managements { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
        public virtual DbSet<RealEstate> RealEstates { get; set; }
        public virtual DbSet<RealEstateDetail> RealEstateDetails { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
        public virtual DbSet<Type> Types { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-LUSNRB7; Database=BLUE; Trusted_Connection=True; TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Management>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("MANAGEMENT");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<Picture>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("PICTURE");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<Price>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("PRICE");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<RealEstate>(entity =>
            {
                entity.ToTable("REAL ESTATE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
                entity.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
                entity.Property(e => e.RealEstateType).HasColumnName("REAL ESTATE TYPE");
                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTER DATE");
                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("TITLE");
                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE DATE");

                entity.HasOne(d => d.RealEstateTypeNavigation).WithMany(p => p.RealEstates)
                    .HasForeignKey(d => d.RealEstateType)
                    .HasConstraintName("FK_REAL ESTATE_REAL ESTATE TYPE");
            });

            modelBuilder.Entity<RealEstateDetail>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("REAL ESTATE DETAIL");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<Size>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("SIZE");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength()
                    .HasColumnName("ID");
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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}