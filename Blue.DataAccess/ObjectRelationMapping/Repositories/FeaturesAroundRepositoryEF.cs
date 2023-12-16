namespace Blue.DataAccess
{
	public class FeaturesAroundRepositoryEF : RepositoryBase<Core.FeaturesAround>, Core.IFeaturesAround
	{
		public FeaturesAroundRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}