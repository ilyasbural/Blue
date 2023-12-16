namespace Blue.DataAccess
{
	public class PictureRepositoryEF : RepositoryBase<Core.Picture>, Core.IPicture
	{
		public PictureRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
		{

		}
	}
}