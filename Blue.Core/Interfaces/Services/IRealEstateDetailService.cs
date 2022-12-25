namespace Blue.Core
{
    public interface IRealEstateDetailService
    {
        Task<Response<RealEstateDetail>> InsertAsync(RealEstateDetailInsertDataTransfer Model);
        Task<Response<RealEstateDetail>> UpdateAsync(RealEstateDetailUpdateDataTransfer Model);
        Task<Response<RealEstateDetail>> DeleteAsync(RealEstateDetailDeleteDataTransfer Model);
        Task<Response<RealEstateDetail>> SelectAsync(RealEstateDetailSelectDataTransfer Model);
        Task<Response<RealEstateDetail>> AnySelectAsync(RealEstateDetailAnyDataTransfer Model);
    }
}