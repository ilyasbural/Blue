namespace Blue.DataAccess
{
    public class DistrictRepositoryEF : RepositoryBase<Core.District>, Core.IDistrictRepository
    {
        public DistrictRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}