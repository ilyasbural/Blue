namespace Blue.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class FurnitureMapping : IEntityTypeConfiguration<Furniture>
    {
        public void Configure(EntityTypeBuilder<Furniture> builder)
        {

        }
    }
}