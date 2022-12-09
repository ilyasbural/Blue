namespace Blue.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class RealEstateMapping
    {
        public void Configure(EntityTypeBuilder<RealEstate> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedNever().HasColumnName("ID");
            builder.Property(e => e.City).HasColumnName("CITY");
            builder.Property(e => e.District).HasColumnName("DISTRICT");
            builder.Property(e => e.Furniture).HasColumnName("FURNITURE");
            builder.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
            builder.Property(e => e.Price).HasColumnName("PRICE");
            builder.Property(e => e.RegisterDate).HasColumnType("datetime").HasColumnName("REGISTER DATE");
            builder.Property(e => e.Size).HasColumnName("SIZE");
            builder.Property(e => e.Title).HasMaxLength(50).HasColumnName("TITLE");
            builder.Property(e => e.Type).HasColumnName("TYPE");
            builder.Property(e => e.UpdateDate) .HasColumnType("datetime").HasColumnName("UPDATE DATE");
            builder.Property(e => e.Warming).HasColumnName("WARMING");

            builder.HasOne(d => d.CityNavigation).WithMany(p => p.RealEstates) .HasForeignKey(d => d.City) .HasConstraintName("FK_REAL ESTATE_CITY");
            builder.HasOne(d => d.DistrictNavigation).WithMany(p => p.RealEstates).HasForeignKey(d => d.District).HasConstraintName("FK_REAL ESTATE_DISTRICT");
            builder.HasOne(d => d.FurnitureNavigation).WithMany(p => p.RealEstates) .HasForeignKey(d => d.Furniture).HasConstraintName("FK_REAL ESTATE_FURNITURE");
            builder.HasOne(d => d.PriceNavigation).WithMany(p => p.RealEstates).HasForeignKey(d => d.Price) .HasConstraintName("FK_REAL ESTATE_PRICE");
            builder.HasOne(d => d.SizeNavigation).WithMany(p => p.RealEstates) .HasForeignKey(d => d.Size) .HasConstraintName("FK_REAL ESTATE_SIZE");
            builder.HasOne(d => d.TypeNavigation).WithMany(p => p.RealEstates).HasForeignKey(d => d.Type).HasConstraintName("FK_REAL ESTATE_REAL ESTATE TYPE");
            builder.HasOne(d => d.WarmingNavigation).WithMany(p => p.RealEstates).HasForeignKey(d => d.Warming).HasConstraintName("FK_REAL ESTATE_WARMING");

            builder.ToTable("REAL ESTATE");
        }
    }
}