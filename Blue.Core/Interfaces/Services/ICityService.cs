namespace Blue.Core
{
    public interface ICityService
    {
        Task<CityServiceResponse> InsertAsync(CityInsertDataTransfer Model);
        Task<CityServiceResponse> UpdateAsync(CityUpdateDataTransfer Model);
        Task<CityServiceResponse> DeleteAsync(CityDeleteDataTransfer Model);
        Task<CityServiceResponse> SelectAsync(CitySelectDataTransfer Model);
        Task<CityServiceResponse> AnySelectAsync(CityAnyDataTransfer Model);
    }
}