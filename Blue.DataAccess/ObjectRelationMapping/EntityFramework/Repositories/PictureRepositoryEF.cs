namespace Blue.DataAccess
{
    public class PictureRepositoryEF : RepositoryBase<Core.Picture>, Core.IPictureRepository
    {
        public PictureRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}