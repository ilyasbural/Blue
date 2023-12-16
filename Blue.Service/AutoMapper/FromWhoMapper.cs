namespace Blue.Service
{
	public class FromWhoMapper : AutoMapper.Profile
	{
		public FromWhoMapper()
		{
			CreateMap<Core.FromWhoRegisterDto, Core.FromWho>().ReverseMap();
			CreateMap<Core.FromWhoUpdateDto, Core.FromWho>().ReverseMap();
			CreateMap<Core.FromWhoDeleteDto, Core.FromWho>().ReverseMap();
			CreateMap<Core.FromWhoSelectDto, Core.FromWho>().ReverseMap();
		}
	}
}