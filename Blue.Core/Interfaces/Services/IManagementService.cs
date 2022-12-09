namespace Blue.Core
{
    public interface IManagementService
    {
        Task<ManagementServiceResponse> InsertAsync(ManagementInsertDataTransfer Model);
        Task<ManagementServiceResponse> UpdateAsync(ManagementUpdateDataTransfer Model);
        Task<ManagementServiceResponse> DeleteAsync(ManagementDeleteDataTransfer Model);
        Task<ManagementServiceResponse> SelectAsync(ManagementSelectDataTransfer Model);
        Task<ManagementServiceResponse> AnySelectAsync(ManagementAnyDataTransfer Model);
    }
}