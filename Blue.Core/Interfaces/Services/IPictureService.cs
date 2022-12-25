namespace Blue.Core
{
    public interface IPictureService
    {
        Task<Response<Picture>> InsertAsync(PictureInsertDataTransfer Model);
        Task<Response<Picture>> UpdateAsync(PictureUpdateDataTransfer Model);
        Task<Response<Picture>> DeleteAsync(PictureDeleteDataTransfer Model);
        Task<Response<Picture>> SelectAsync(PictureSelectDataTransfer Model);
        Task<Response<Picture>> AnySelectAsync(PictureAnyDataTransfer Model);
    }
}