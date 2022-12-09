namespace Blue.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ManagementMapping : IEntityTypeConfiguration<Management>
    {
        public void Configure(EntityTypeBuilder<Management> builder)
        {

        }
    }
}