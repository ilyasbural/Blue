namespace Blue.DataAccess
{
    public class SizeRepositoryEF : RepositoryBase<Core.Size>, Core.ISizeRepository
    {
        public SizeRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}