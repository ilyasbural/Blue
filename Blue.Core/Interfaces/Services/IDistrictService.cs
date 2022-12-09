namespace Blue.Core
{
    public interface IDistrictService
    {
        Task<DistrictServiceResponse> InsertAsync(DistrictInsertDataTransfer Model);
        Task<DistrictServiceResponse> UpdateAsync(DistrictUpdateDataTransfer Model);
        Task<DistrictServiceResponse> DeleteAsync(DistrictDeleteDataTransfer Model);
        Task<DistrictServiceResponse> SelectAsync(DistrictSelectDataTransfer Model);
        Task<DistrictServiceResponse> AnySelectAsync(DistrictAnyDataTransfer Model);
    }
}