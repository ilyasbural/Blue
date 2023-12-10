namespace Blue.Core
{
    public interface IBuildingTypeService
    {
        Task<Response<BuildingType>> InsertAsync(BuildingTypeRegisterDto Model);
    }
}