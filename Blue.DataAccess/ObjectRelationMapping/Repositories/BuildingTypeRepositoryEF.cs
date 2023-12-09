namespace Blue.DataAccess
{
    public class BuildingTypeRepositoryEF : RepositoryBase<Core.BuildingType>, Core.IBuildingType
    {
        public BuildingTypeRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}