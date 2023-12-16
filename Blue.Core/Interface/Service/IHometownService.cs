namespace Blue.Core
{
	public interface IHometownService
	{
		Task<Response<Hometown>> InsertAsync(HometownRegisterDto Model);
		Task<Response<Hometown>> UpdateAsync(HometownUpdateDto Model);
		Task<Response<Hometown>> DeleteAsync(HometownDeleteDto Model);
		Task<Response<Hometown>> SelectAsync(HometownSelectDto Model);
		Task<Response<Hometown>> SelectSingleAsync(HometownSelectDto Model);
	}
}