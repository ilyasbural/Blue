namespace Blue.Core
{
	public interface IRealEstateDetailService
	{
		Task<Response<RealEstateDetail>> InsertAsync(RealEstateDetailRegisterDto Model);
		Task<Response<RealEstateDetail>> UpdateAsync(RealEstateDetailUpdateDto Model);
		Task<Response<RealEstateDetail>> DeleteAsync(RealEstateDetailDeleteDto Model);
		Task<Response<RealEstateDetail>> SelectAsync(RealEstateDetailSelectDto Model);
		Task<Response<RealEstateDetail>> SelectSingleAsync(RealEstateDetailSelectDto Model);
	}
}