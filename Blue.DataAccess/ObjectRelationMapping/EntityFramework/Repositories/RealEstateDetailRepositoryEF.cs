namespace Blue.DataAccess
{
    public class RealEstateDetailRepositoryEF : RepositoryBase<Core.RealEstateDetail>, Core.IRealEstateDetailRepository
    {
        public RealEstateDetailRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}