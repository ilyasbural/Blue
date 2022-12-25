namespace Blue.Core
{
    public interface IPriceService
    {
        Task<Response<Price>> InsertAsync(PriceInsertDataTransfer Model);
        Task<Response<Price>> UpdateAsync(PriceUpdateDataTransfer Model);
        Task<Response<Price>> DeleteAsync(PriceDeleteDataTransfer Model);
        Task<Response<Price>> SelectAsync(PriceSelectDataTransfer Model);
        Task<Response<Price>> AnySelectAsync(PriceAnyDataTransfer Model);
    }
}