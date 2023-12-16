namespace Blue.DataAccess
{
	public class FeaturesOutsideRepositoryEF : RepositoryBase<Core.FeaturesOutside>, Core.IFeaturesOutside
	{
		public FeaturesOutsideRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}