namespace Blue.Core
{
    public interface IFromWhoService
    {
        Task<Response<FromWho>> InsertAsync(FromWhoRegisterDto Model);
        Task<Response<FromWho>> UpdateAsync(FromWhoUpdateDto Model);
        Task<Response<FromWho>> DeleteAsync(FromWhoDeleteDto Model);
        Task<Response<FromWho>> SelectAsync(FromWhoSelectDto Model);
        Task<Response<FromWho>> SelectSingleAsync(FromWhoSelectDto Model);
    }
}