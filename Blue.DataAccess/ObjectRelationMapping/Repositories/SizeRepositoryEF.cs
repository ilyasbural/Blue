namespace Blue.DataAccess
{
    public class SizeRepositoryEF : RepositoryBase<Core.Size>, Core.ISize
    {
        public SizeRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}