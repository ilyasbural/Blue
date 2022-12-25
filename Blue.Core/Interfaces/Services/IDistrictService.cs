namespace Blue.Core
{
    public interface IDistrictService
    {
        Task<Response<District>> InsertAsync(DistrictInsertDataTransfer Model);
        Task<Response<District>> UpdateAsync(DistrictUpdateDataTransfer Model);
        Task<Response<District>> DeleteAsync(DistrictDeleteDataTransfer Model);
        Task<Response<District>> SelectAsync(DistrictSelectDataTransfer Model);
        Task<Response<District>> AnySelectAsync(DistrictAnyDataTransfer Model);
    }
}