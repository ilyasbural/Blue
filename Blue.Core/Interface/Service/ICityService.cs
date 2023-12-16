namespace Blue.Core
{
	public interface ICityService
	{
		Task<Response<City>> InsertAsync(CityRegisterDto Model);
		Task<Response<City>> UpdateAsync(CityUpdateDto Model);
		Task<Response<City>> DeleteAsync(CityDeleteDto Model);
		Task<Response<City>> SelectAsync(CitySelectDto Model);
		Task<Response<City>> SelectSingleAsync(CitySelectDto Model);
	}
}