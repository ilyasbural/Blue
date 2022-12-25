namespace Blue.Core
{
    public interface ISizeService
    {
        Task<Response<Size>> InsertAsync(SizeInsertDataTransfer Model);
        Task<Response<Size>> UpdateAsync(SizeUpdateDataTransfer Model);
        Task<Response<Size>> DeleteAsync(SizeDeleteDataTransfer Model);
        Task<Response<Size>> SelectAsync(SizeSelectDataTransfer Model);
        Task<Response<Size>> AnySelectAsync(SizeAnyDataTransfer Model);
    }
}