namespace Blue.Core
{
    public interface ICityService
    {
        Task<Response<City>> InsertAsync(CityInsertDataTransfer Model);
        Task<Response<City>> UpdateAsync(CityUpdateDataTransfer Model);
        Task<Response<City>> DeleteAsync(CityDeleteDataTransfer Model);
        Task<Response<City>> SelectAsync(CitySelectDataTransfer Model);
        Task<Response<City>> AnySelectAsync(CityAnyDataTransfer Model);
    }
}