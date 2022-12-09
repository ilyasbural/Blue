namespace Blue.Core
{
    public interface IRealEstateService
    {
        Task<RealEstateServiceResponse> InsertAsync(RealEstateInsertDataTransfer Model);
        Task<RealEstateServiceResponse> UpdateAsync(RealEstateUpdateDataTransfer Model);
        Task<RealEstateServiceResponse> DeleteAsync(RealEstateDeleteDataTransfer Model);
        Task<RealEstateServiceResponse> SelectAsync(RealEstateSelectDataTransfer Model);
        Task<RealEstateServiceResponse> AnySelectAsync(RealEstateAnyDataTransfer Model);
    }
}