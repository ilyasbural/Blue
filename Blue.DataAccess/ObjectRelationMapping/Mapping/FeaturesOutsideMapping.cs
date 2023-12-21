namespace Blue.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class FeaturesOutsideMapping : IEntityTypeConfiguration<FeaturesOutside>
    {
        public void Configure(EntityTypeBuilder<FeaturesOutside> builder)
        {
            builder.Property(e => e.Id);
            builder.Property(x => x.RegisterDate).HasColumnType("DATETIME");
            builder.Property(x => x.UpdateDate).HasColumnType("DATETIME");
            builder.Property(e => e.IsActive);
            builder.ToTable("FeaturesOutside");
        }
    }
}