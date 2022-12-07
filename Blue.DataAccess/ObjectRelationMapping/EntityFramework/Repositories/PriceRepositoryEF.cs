namespace Blue.DataAccess
{
    public class PriceRepositoryEF : RepositoryBase<Core.Price>, Core.IPriceRepository
    {
        public PriceRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}