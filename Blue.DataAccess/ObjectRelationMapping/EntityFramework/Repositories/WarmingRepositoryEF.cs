namespace Blue.DataAccess
{
    public class WarmingRepositoryEF : RepositoryBase<Core.Warming>, Core.IWarmingRepository
    {
        public WarmingRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}