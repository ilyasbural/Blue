namespace Blue.Core
{
	public interface ITypeService
	{
		Task<Response<Type>> InsertAsync(TypeRegisterDto Model);
		Task<Response<Type>> UpdateAsync(TypeUpdateDto Model);
		Task<Response<Type>> DeleteAsync(TypeDeleteDto Model);
		Task<Response<Type>> SelectAsync(TypeSelectDto Model);
		Task<Response<Type>> SelectSingleAsync(TypeSelectDto Model);
	}
}