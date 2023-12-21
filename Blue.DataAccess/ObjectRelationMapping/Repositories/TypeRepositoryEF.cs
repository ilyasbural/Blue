namespace Blue.DataAccess
{
    public class TypeRepositoryEF : RepositoryBase<Core.Type>, Core.IType
    {
        public TypeRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}