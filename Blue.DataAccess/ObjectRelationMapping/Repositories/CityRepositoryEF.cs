namespace Blue.DataAccess
{
    public class CityRepositoryEF : RepositoryBase<Core.City>, Core.ICity
    {
        public CityRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}