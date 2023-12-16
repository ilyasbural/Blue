namespace Blue.DataAccess
{
	public class RealEstateDetailRepositoryEF : RepositoryBase<Core.RealEstateDetail>, Core.IRealEstateDetail
	{
		public RealEstateDetailRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}