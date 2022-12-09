namespace Blue.Core
{
    public interface IFurnitureService
    {
        Task<FurnitureServiceResponse> InsertAsync(FurnitureInsertDataTransfer Model);
        Task<FurnitureServiceResponse> UpdateAsync(FurnitureUpdateDataTransfer Model);
        Task<FurnitureServiceResponse> DeleteAsync(FurnitureDeleteDataTransfer Model);
        Task<FurnitureServiceResponse> SelectAsync(FurnitureSelectDataTransfer Model);
        Task<FurnitureServiceResponse> AnySelectAsync(FurnitureAnyDataTransfer Model);
    }
}