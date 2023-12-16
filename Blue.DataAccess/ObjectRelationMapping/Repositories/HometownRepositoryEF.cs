namespace Blue.DataAccess
{
	public class HometownRepositoryEF : RepositoryBase<Core.Hometown>, Core.IHometown
	{
		public HometownRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}