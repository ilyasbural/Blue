namespace Blue.Core
{
    public interface ICityService
    {
        Task<CityServiceResponse> AddAsync(CityInsertDataTransfer Model);
    }
}