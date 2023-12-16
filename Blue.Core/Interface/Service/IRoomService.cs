namespace Blue.Core
{
	public interface IRoomService
	{
		Task<Response<Room>> InsertAsync(RoomRegisterDto Model);
		Task<Response<Room>> UpdateAsync(RoomUpdateDto Model);
		Task<Response<Room>> DeleteAsync(RoomDeleteDto Model);
		Task<Response<Room>> SelectAsync(RoomSelectDto Model);
		Task<Response<Room>> SelectSingleAsync(RoomSelectDto Model);
	}
}