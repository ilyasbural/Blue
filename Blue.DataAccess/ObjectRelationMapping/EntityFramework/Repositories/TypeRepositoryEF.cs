namespace Blue.DataAccess
{
    public class TypeRepositoryEF : RepositoryBase<Core.Type>, Core.ITypeRepository
    {
        public TypeRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}