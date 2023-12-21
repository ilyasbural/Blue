namespace Blue.Service
{
    public class ManagementMapper : AutoMapper.Profile
    {
        public ManagementMapper()
        {
            CreateMap<Core.ManagementRegisterDto, Core.Management>().ReverseMap();
            CreateMap<Core.ManagementUpdateDto, Core.Management>().ReverseMap();
            CreateMap<Core.ManagementDeleteDto, Core.Management>().ReverseMap();
            CreateMap<Core.ManagementSelectDto, Core.Management>().ReverseMap();
        }
    }
}