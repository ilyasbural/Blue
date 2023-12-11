namespace Blue.Core
{
    public interface IStatusService
    {
        Task<Response<Status>> InsertAsync(StatusRegisterDto Model);
        Task<Response<Status>> UpdateAsync(StatusUpdateDto Model);
        Task<Response<Status>> DeleteAsync(StatusDeleteDto Model);
    }
}