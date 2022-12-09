namespace Blue.Core
{
    public interface IPictureService
    {
        Task<PictureServiceResponse> InsertAsync(PictureInsertDataTransfer Model);
        Task<PictureServiceResponse> UpdateAsync(PictureUpdateDataTransfer Model);
        Task<PictureServiceResponse> DeleteAsync(PictureDeleteDataTransfer Model);
        Task<PictureServiceResponse> SelectAsync(PictureSelectDataTransfer Model);
        Task<PictureServiceResponse> AnySelectAsync(PictureAnyDataTransfer Model);
    }
}