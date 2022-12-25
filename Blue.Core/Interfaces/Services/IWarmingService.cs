namespace Blue.Core
{
    public interface IWarmingService
    {
        Task<Response<Warming>> InsertAsync(WarmingInsertDataTransfer Model);
        Task<Response<Warming>> UpdateAsync(WarmingUpdateDataTransfer Model);
        Task<Response<Warming>> DeleteAsync(WarmingDeleteDataTransfer Model);
        Task<Response<Warming>> SelectAsync(WarmingSelectDataTransfer Model);
        Task<Response<Warming>> AnySelectAsync(WarmingAnyDataTransfer Model);
    }
}