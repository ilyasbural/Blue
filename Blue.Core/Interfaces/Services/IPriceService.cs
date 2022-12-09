namespace Blue.Core
{
    public interface IPriceService
    {
        Task<PriceServiceResponse> InsertAsync(PriceInsertDataTransfer Model);
        Task<PriceServiceResponse> UpdateAsync(PriceUpdateDataTransfer Model);
        Task<PriceServiceResponse> DeleteAsync(PriceDeleteDataTransfer Model);
        Task<PriceServiceResponse> SelectAsync(PriceSelectDataTransfer Model);
        Task<PriceServiceResponse> AnySelectAsync(PriceAnyDataTransfer Model);
    }
}