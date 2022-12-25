namespace Blue.Core
{
    public interface ITypeService
    {
        Task<Response<Type>> InsertAsync(TypeInsertDataTransfer Model);
        Task<Response<Type>> UpdateAsync(TypeUpdateDataTransfer Model);
        Task<Response<Type>> DeleteAsync(TypeDeleteDataTransfer Model);
        Task<Response<Type>> SelectAsync(TypeSelectDataTransfer Model);
        Task<Response<Type>> AnySelectAsync(TypeAnyDataTransfer Model);
    }
}