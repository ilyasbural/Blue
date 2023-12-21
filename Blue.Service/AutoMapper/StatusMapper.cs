namespace Blue.Service
{
    public class StatusMapper : AutoMapper.Profile
    {
        public StatusMapper()
        {
            CreateMap<Core.StatusRegisterDto, Core.Status>().ReverseMap();
            CreateMap<Core.StatusUpdateDto, Core.Status>().ReverseMap();
            CreateMap<Core.StatusDeleteDto, Core.Status>().ReverseMap();
            CreateMap<Core.StatusSelectDto, Core.Status>().ReverseMap();
        }
    }
}