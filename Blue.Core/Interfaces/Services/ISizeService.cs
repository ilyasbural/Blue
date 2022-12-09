namespace Blue.Core
{
    public interface ISizeService
    {
        Task<SizeServiceResponse> InsertAsync(SizeInsertDataTransfer Model);
        Task<SizeServiceResponse> UpdateAsync(SizeUpdateDataTransfer Model);
        Task<SizeServiceResponse> DeleteAsync(SizeDeleteDataTransfer Model);
        Task<SizeServiceResponse> SelectAsync(SizeSelectDataTransfer Model);
        Task<SizeServiceResponse> AnySelectAsync(SizeAnyDataTransfer Model);
    }
}