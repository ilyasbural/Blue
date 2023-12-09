namespace Blue.DataAccess
{
    public class RoomRepositoryEF : RepositoryBase<Core.Room>, Core.IRoom
    {
        public RoomRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}