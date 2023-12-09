namespace Blue.DataAccess
{
    public class FromWhoRepositoryEF : RepositoryBase<Core.FromWho>, Core.IFromWho
    {
        public FromWhoRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}