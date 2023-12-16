namespace Blue.Service
{
	public class PriceMapper : AutoMapper.Profile
	{
		public PriceMapper()
		{
			CreateMap<Core.PriceRegisterDto, Core.Price>().ReverseMap();
			CreateMap<Core.PriceUpdateDto, Core.Price>().ReverseMap();
			CreateMap<Core.PriceDeleteDto, Core.Price>().ReverseMap();
			CreateMap<Core.PriceSelectDto, Core.Price>().ReverseMap();
		}
	}
}