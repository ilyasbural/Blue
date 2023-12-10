namespace Blue.Service
{
    public class FeaturesOutsideMapper : AutoMapper.Profile
    {
        public FeaturesOutsideMapper()
        {
            CreateMap<Core.FeaturesOutsideRegisterDto, Core.FeaturesOutside>().ReverseMap();
            CreateMap<Core.FeaturesOutsideUpdateDto, Core.FeaturesOutside>().ReverseMap();
            CreateMap<Core.FeaturesOutsideDeleteDto, Core.FeaturesOutside>().ReverseMap();
            CreateMap<Core.FeaturesOutsideSelectDto, Core.FeaturesOutside>().ReverseMap();
        }
    }
}