namespace Blue.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class WarmingMapping : IEntityTypeConfiguration<Warming>
    {
        public void Configure(EntityTypeBuilder<Warming> builder)
        {

        }
    }
}