namespace Blue.Core
{
    public interface IFuelTypeService
    {
        Task<Response<FuelType>> InsertAsync(FuelTypeRegisterDto Model);
    }
}