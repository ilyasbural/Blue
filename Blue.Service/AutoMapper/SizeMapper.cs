namespace Blue.Service
{
	public class SizeMapper : AutoMapper.Profile
	{
		public SizeMapper()
		{
			CreateMap<Core.SizeRegisterDto, Core.Size>().ReverseMap();
			CreateMap<Core.SizeUpdateDto, Core.Size>().ReverseMap();
			CreateMap<Core.SizeDeleteDto, Core.Size>().ReverseMap();
			CreateMap<Core.SizeSelectDto, Core.Size>().ReverseMap();
		}
	}
}