namespace Blue.Service
{
	public class CityMapper : AutoMapper.Profile
	{
		public CityMapper()
		{
			CreateMap<Core.CityRegisterDto, Core.City>().ReverseMap();
			CreateMap<Core.CityUpdateDto, Core.City>().ReverseMap();
			CreateMap<Core.CityDeleteDto, Core.City>().ReverseMap();
			CreateMap<Core.CitySelectDto, Core.City>().ReverseMap();
		}
	}
}