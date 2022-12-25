namespace Blue.Core
{
    public interface IFurnitureService
    {
        Task<Response<Furniture>> InsertAsync(FurnitureInsertDataTransfer Model);
        Task<Response<Furniture>> UpdateAsync(FurnitureUpdateDataTransfer Model);
        Task<Response<Furniture>> DeleteAsync(FurnitureDeleteDataTransfer Model);
        Task<Response<Furniture>> SelectAsync(FurnitureSelectDataTransfer Model);
        Task<Response<Furniture>> AnySelectAsync(FurnitureAnyDataTransfer Model);
    }
}