namespace Blue.Core
{
    public interface IRoomService
    {
        Task<Response<Room>> InsertAsync(RoomRegisterDto Model);
    }
}