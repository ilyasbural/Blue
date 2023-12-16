namespace Blue.DataAccess
{
	public class RealEstateRepositoryEF : RepositoryBase<Core.RealEstate>, Core.IRealEstate
	{
		public RealEstateRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}