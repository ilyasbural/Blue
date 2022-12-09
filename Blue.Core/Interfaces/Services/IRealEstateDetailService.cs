namespace Blue.Core
{
    public interface IRealEstateDetailService
    {
        Task<RealEstateDetailServiceResponse> InsertAsync(RealEstateDetailInsertDataTransfer Model);
        Task<RealEstateDetailServiceResponse> UpdateAsync(RealEstateDetailUpdateDataTransfer Model);
        Task<RealEstateDetailServiceResponse> DeleteAsync(RealEstateDetailDeleteDataTransfer Model);
        Task<RealEstateDetailServiceResponse> SelectAsync(RealEstateDetailSelectDataTransfer Model);
        Task<RealEstateDetailServiceResponse> AnySelectAsync(RealEstateDetailAnyDataTransfer Model);
    }
}