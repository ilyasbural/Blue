namespace Blue.Service
{
	public class HometownMapper : AutoMapper.Profile
	{
		public HometownMapper()
		{
			CreateMap<Core.HometownRegisterDto, Core.Hometown>().ReverseMap();
			CreateMap<Core.HometownUpdateDto, Core.Hometown>().ReverseMap();
			CreateMap<Core.HometownDeleteDto, Core.Hometown>().ReverseMap();
			CreateMap<Core.HometownSelectDto, Core.Hometown>().ReverseMap();
		}
	}
}