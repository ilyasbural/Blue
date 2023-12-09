namespace Blue.Service
{
    public class RealEstateMapper : AutoMapper.Profile
    {
        public RealEstateMapper()
        {
            CreateMap<Core.RealEstateRegisterDto, Core.RealEstate>().ReverseMap();
            CreateMap<Core.RealEstateUpdateDto, Core.RealEstate>().ReverseMap();
            CreateMap<Core.RealEstateDeleteDto, Core.RealEstate>().ReverseMap();
            CreateMap<Core.RealEstateSelectDto, Core.RealEstate>().ReverseMap();
        }
    }
}