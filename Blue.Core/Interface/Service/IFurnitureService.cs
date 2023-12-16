namespace Blue.Core
{
	public interface IFurnitureService
	{
		Task<Response<Furniture>> InsertAsync(FurnitureRegisterDto Model);
		Task<Response<Furniture>> UpdateAsync(FurnitureUpdateDto Model);
		Task<Response<Furniture>> DeleteAsync(FurnitureDeleteDto Model);
		Task<Response<Furniture>> SelectAsync(FurnitureSelectDto Model);
		Task<Response<Furniture>> SelectSingleAsync(FurnitureSelectDto Model);
	}
}