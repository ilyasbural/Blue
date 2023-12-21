namespace Blue.Core
{
    public interface IBuildingTypeService
    {
        Task<Response<BuildingType>> InsertAsync(BuildingTypeRegisterDto Model);
        Task<Response<BuildingType>> UpdateAsync(BuildingTypeUpdateDto Model);
        Task<Response<BuildingType>> DeleteAsync(BuildingTypeDeleteDto Model);
        Task<Response<BuildingType>> SelectAsync(BuildingTypeSelectDto Model);
        Task<Response<BuildingType>> SelectSingleAsync(BuildingTypeSelectDto Model);
    }
}