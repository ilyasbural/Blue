namespace Blue.Service
{
    public class FeaturesInsideMapper : AutoMapper.Profile
    {
        public FeaturesInsideMapper()
        {
            CreateMap<Core.FeaturesInsideRegisterDto, Core.FeaturesInside>().ReverseMap();
            CreateMap<Core.FeaturesInsideUpdateDto, Core.FeaturesInside>().ReverseMap();
            CreateMap<Core.FeaturesInsideDeleteDto, Core.FeaturesInside>().ReverseMap();
            CreateMap<Core.FeaturesInsideSelectDto, Core.FeaturesInside>().ReverseMap();
        }
    }
}