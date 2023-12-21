namespace Blue.DataAccess
{
    public class FuelTypeRepositoryEF : RepositoryBase<Core.FuelType>, Core.IFuelType
    {
        public FuelTypeRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}