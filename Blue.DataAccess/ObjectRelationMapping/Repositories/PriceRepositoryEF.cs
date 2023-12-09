namespace Blue.DataAccess
{
    public class PriceRepositoryEF : RepositoryBase<Core.Price>, Core.IPrice
    {
        public PriceRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}