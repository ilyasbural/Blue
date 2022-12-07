namespace Blue.DataAccess
{
    public class FurnitureRepositoryEF : RepositoryBase<Core.Furniture>, Core.IFurnitureRepository
    {
        public FurnitureRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}