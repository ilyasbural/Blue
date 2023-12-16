namespace Blue.Core
{
	public interface IPriceService
	{
		Task<Response<Price>> InsertAsync(PriceRegisterDto Model);
		Task<Response<Price>> UpdateAsync(PriceUpdateDto Model);
		Task<Response<Price>> DeleteAsync(PriceDeleteDto Model);
		Task<Response<Price>> SelectAsync(PriceSelectDto Model);
		Task<Response<Price>> SelectSingleAsync(PriceSelectDto Model);
	}
}