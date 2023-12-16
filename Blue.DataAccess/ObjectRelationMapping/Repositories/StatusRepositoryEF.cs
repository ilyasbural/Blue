namespace Blue.DataAccess
{
	public class StatusRepositoryEF : RepositoryBase<Core.Status>, Core.IStatus
	{
		public StatusRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}