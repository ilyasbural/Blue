namespace Blue.DataAccess
{
    public class RealEstateRepositoryEF : RepositoryBase<Core.RealEstate>, Core.IRealEstateRepository
    {
        public RealEstateRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}