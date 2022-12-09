namespace Blue.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class CityMapping : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedNever().HasColumnName("ID");
            builder.Property(e => e.Name).HasMaxLength(50).HasColumnName("NAME");
            builder.Property(e => e.RegisterDate).HasColumnType("DATE").HasColumnName("REGISTER DATE");
            builder.Property(e => e.UpdateDate).HasColumnType("DATE").HasColumnName("UPDATE DATE");
            builder.Property(e => e.IsActive).HasColumnName("IS ACTIVE");
            builder.ToTable("CITY");
        }
    }
}