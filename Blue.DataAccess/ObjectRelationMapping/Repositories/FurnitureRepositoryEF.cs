namespace Blue.DataAccess
{
	public class FurnitureRepositoryEF : RepositoryBase<Core.Furniture>, Core.IFurniture
	{
		public FurnitureRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}