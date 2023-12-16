namespace Blue.Core
{
	public interface IBuyingTypeService
	{
		Task<Response<BuyingType>> InsertAsync(BuyingTypeRegisterDto Model);
		Task<Response<BuyingType>> UpdateAsync(BuyingTypeUpdateDto Model);
		Task<Response<BuyingType>> DeleteAsync(BuyingTypeDeleteDto Model);
		Task<Response<BuyingType>> SelectAsync(BuyingTypeSelectDto Model);
		Task<Response<BuyingType>> SelectSingleAsync(BuyingTypeSelectDto Model);
	}
}