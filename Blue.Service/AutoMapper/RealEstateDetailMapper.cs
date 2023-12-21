namespace Blue.Service
{
    public class RealEstateDetailMapper : AutoMapper.Profile
    {
        public RealEstateDetailMapper()
        {
            CreateMap<Core.RealEstateDetailRegisterDto, Core.RealEstateDetail>().ReverseMap();
            CreateMap<Core.RealEstateDetailUpdateDto, Core.RealEstateDetail>().ReverseMap();
            CreateMap<Core.RealEstateDetailDeleteDto, Core.RealEstateDetail>().ReverseMap();
            CreateMap<Core.RealEstateDetailSelectDto, Core.RealEstateDetail>().ReverseMap();
        }
    }
}