namespace Blue.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class RealEstateDetailMapping : IEntityTypeConfiguration<RealEstateDetail>
    {
        public void Configure(EntityTypeBuilder<RealEstateDetail> builder)
        {

        }
    }
}