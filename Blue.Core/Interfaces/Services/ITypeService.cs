namespace Blue.Core
{
    public interface ITypeService
    {
        Task<TypeServiceResponse> InsertAsync(TypeInsertDataTransfer Model);
        Task<TypeServiceResponse> UpdateAsync(TypeUpdateDataTransfer Model);
        Task<TypeServiceResponse> DeleteAsync(TypeDeleteDataTransfer Model);
        Task<TypeServiceResponse> SelectAsync(TypeSelectDataTransfer Model);
        Task<TypeServiceResponse> AnySelectAsync(TypeAnyDataTransfer Model);
    }
}