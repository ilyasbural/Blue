namespace Blue.DataAccess
{
	public class WarmingRepositoryEF : RepositoryBase<Core.Warming>, Core.IWarming
	{
		public WarmingRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}