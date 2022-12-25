namespace Blue.Core
{
    public interface IRealEstateService
    {
        Task<Response<RealEstate>> InsertAsync(RealEstateInsertDataTransfer Model);
        Task<Response<RealEstate>> UpdateAsync(RealEstateUpdateDataTransfer Model);
        Task<Response<RealEstate>> DeleteAsync(RealEstateDeleteDataTransfer Model);
        Task<Response<RealEstate>> SelectAsync(RealEstateSelectDataTransfer Model);
        Task<Response<RealEstate>> AnySelectAsync(RealEstateAnyDataTransfer Model);
    }
}