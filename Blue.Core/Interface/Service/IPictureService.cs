namespace Blue.Core
{
    public interface IPictureService
    {
        Task<Response<Picture>> InsertAsync(PictureRegisterDto Model);
        Task<Response<Picture>> UpdateAsync(PictureUpdateDto Model);
        Task<Response<Picture>> DeleteAsync(PictureDeleteDto Model);
        Task<Response<Picture>> SelectAsync(PictureSelectDto Model);
        Task<Response<Picture>> SelectSingleAsync(PictureSelectDto Model);
    }
}