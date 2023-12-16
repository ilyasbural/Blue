namespace Blue.DataAccess
{
	public class FeaturesInsideRepositoryEF : RepositoryBase<Core.FeaturesInside>, Core.IFeaturesInside
	{
		public FeaturesInsideRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}