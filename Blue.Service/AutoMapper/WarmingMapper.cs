namespace Blue.Service
{
	public class WarmingMapper : AutoMapper.Profile
	{
		public WarmingMapper()
		{
			CreateMap<Core.WarmingRegisterDto, Core.Warming>().ReverseMap();
			CreateMap<Core.WarmingUpdateDto, Core.Warming>().ReverseMap();
			CreateMap<Core.WarmingDeleteDto, Core.Warming>().ReverseMap();
			CreateMap<Core.WarmingSelectDto, Core.Warming>().ReverseMap();
		}
	}
}