namespace Blue.Core
{
    public interface IHometownService
    {
        Task<Response<Hometown>> InsertAsync(HometownRegisterDto Model);
    }
}