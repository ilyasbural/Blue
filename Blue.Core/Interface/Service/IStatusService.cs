namespace Blue.Core
{
    public interface IStatusService
    {
        Task<Response<Status>> InsertAsync(StatusRegisterDto Model);
    }
}