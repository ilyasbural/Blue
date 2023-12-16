namespace Blue.Service
{
	public class RoomMapper : AutoMapper.Profile
	{
		public RoomMapper()
		{
			CreateMap<Core.RoomRegisterDto, Core.Room>().ReverseMap();
			CreateMap<Core.RoomUpdateDto, Core.Room>().ReverseMap();
			CreateMap<Core.RoomDeleteDto, Core.Room>().ReverseMap();
			CreateMap<Core.RoomSelectDto, Core.Room>().ReverseMap();
		}
	}
}