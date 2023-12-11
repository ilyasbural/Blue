namespace Blue.Core
{
    public interface IFromWhoService
    {
        Task<Response<FromWho>> InsertAsync(FromWhoRegisterDto Model);
        Task<Response<FromWho>> UpdateAsync(FromWhoUpdateDto Model);
    }
}