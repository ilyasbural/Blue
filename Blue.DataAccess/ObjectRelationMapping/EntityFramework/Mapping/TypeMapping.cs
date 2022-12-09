namespace Blue.DataAccess
{
    using Core;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class TypeMapping : IEntityTypeConfiguration<Type>
    {
        public void Configure(EntityTypeBuilder<Type> builder)
        {

        }
    }
}