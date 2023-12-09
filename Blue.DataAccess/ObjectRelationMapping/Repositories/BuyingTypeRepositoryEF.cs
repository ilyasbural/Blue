namespace Blue.DataAccess
{
    public class BuyingTypeRepositoryEF : RepositoryBase<Core.BuyingType>, Core.IBuyingType
    {
        public BuyingTypeRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}