namespace Blue.Core
{
    public interface IBuyingTypeService
    {
        Task<Response<BuyingType>> InsertAsync(BuyingTypeRegisterDto Model);
    }
}