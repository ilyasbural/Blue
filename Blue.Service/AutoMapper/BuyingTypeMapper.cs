namespace Blue.Service
{
    public class BuyingTypeMapper : AutoMapper.Profile
    {
        public BuyingTypeMapper()
        {
            CreateMap<Core.BuyingTypeRegisterDto, Core.BuyingType>().ReverseMap();
            CreateMap<Core.BuyingTypeUpdateDto, Core.BuyingType>().ReverseMap();
            CreateMap<Core.BuyingTypeDeleteDto, Core.BuyingType>().ReverseMap();
            CreateMap<Core.BuyingTypeSelectDto, Core.BuyingType>().ReverseMap();
        }
    }
}