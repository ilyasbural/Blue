namespace Blue.Core
{
    public interface IFuelTypeService
    {
        Task<Response<FuelType>> InsertAsync(FuelTypeRegisterDto Model);
        Task<Response<FuelType>> UpdateAsync(FuelTypeUpdateDto Model);
        Task<Response<FuelType>> DeleteAsync(FuelTypeDeleteDto Model);
    }
}