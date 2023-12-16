namespace Blue.DataAccess
{
	using Core;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	public class CityMapping : IEntityTypeConfiguration<City>
	{
		public void Configure(EntityTypeBuilder<City> builder)
		{
			builder.Property(e => e.Id);
			builder.Property(x => x.RegisterDate).HasColumnType("DATETIME");
			builder.Property(x => x.UpdateDate).HasColumnType("DATETIME");
			builder.Property(e => e.IsActive);
			builder.ToTable("City");
		}
	}
}