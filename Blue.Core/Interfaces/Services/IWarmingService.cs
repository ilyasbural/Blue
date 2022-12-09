namespace Blue.Core
{
    public interface IWarmingService
    {
        Task<WarmingServiceResponse> InsertAsync(WarmingInsertDataTransfer Model);
        Task<WarmingServiceResponse> UpdateAsync(WarmingUpdateDataTransfer Model);
        Task<WarmingServiceResponse> DeleteAsync(WarmingDeleteDataTransfer Model);
        Task<WarmingServiceResponse> SelectAsync(WarmingSelectDataTransfer Model);
        Task<WarmingServiceResponse> AnySelectAsync(WarmingAnyDataTransfer Model);
    }
}