namespace Blue.DataAccess
{
	using Core;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	public class FeaturesInsideMapping : IEntityTypeConfiguration<FeaturesInside>
	{
		public void Configure(EntityTypeBuilder<FeaturesInside> builder)
		{
			builder.Property(e => e.Id);
			builder.Property(x => x.RegisterDate).HasColumnType("DATETIME");
			builder.Property(x => x.UpdateDate).HasColumnType("DATETIME");
			builder.Property(e => e.IsActive);
			builder.ToTable("FeaturesInside");
		}
	}
}