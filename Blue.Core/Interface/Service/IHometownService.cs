namespace Blue.Core
{
    public interface IHometownService
    {
        Task<Response<Hometown>> InsertAsync(HometownRegisterDto Model);
        Task<Response<Hometown>> UpdateAsync(HometownUpdateDto Model);
        Task<Response<Hometown>> DeleteAsync(HometownDeleteDto Model);
    }
}