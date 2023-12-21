namespace Blue.Service
{
    public class FeaturesAroundMapper : AutoMapper.Profile
    {
        public FeaturesAroundMapper()
        {
            CreateMap<Core.FeaturesAroundRegisterDto, Core.FeaturesAround>().ReverseMap();
            CreateMap<Core.FeaturesAroundUpdateDto, Core.FeaturesAround>().ReverseMap();
            CreateMap<Core.FeaturesAroundDeleteDto, Core.FeaturesAround>().ReverseMap();
            CreateMap<Core.FeaturesAroundSelectDto, Core.FeaturesAround>().ReverseMap();
        }
    }
}