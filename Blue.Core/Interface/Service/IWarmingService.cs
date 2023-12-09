namespace Blue.Core
{
    public interface IWarmingService
    {
        Task<Response<Warming>> InsertAsync(WarmingRegisterDto Model);
        Task<Response<Warming>> UpdateAsync(WarmingUpdateDto Model);
        Task<Response<Warming>> DeleteAsync(WarmingDeleteDto Model);
        Task<Response<Warming>> SelectAsync(WarmingSelectDto Model);
        Task<Response<Warming>> SelectSingleAsync(WarmingSelectDto Model);
    }
}