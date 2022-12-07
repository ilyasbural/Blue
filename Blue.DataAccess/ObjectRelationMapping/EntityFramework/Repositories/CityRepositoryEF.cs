namespace Blue.DataAccess
{
    public class CityRepositoryEF : RepositoryBase<Core.City>, Core.ICityRepository
    {
        public CityRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}