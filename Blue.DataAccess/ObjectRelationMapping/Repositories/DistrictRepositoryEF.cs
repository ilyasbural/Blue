namespace Blue.DataAccess
{
	public class DistrictRepositoryEF : RepositoryBase<Core.District>, Core.IDistrict
	{
		public DistrictRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}