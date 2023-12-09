namespace Blue.Service
{
    public class DistrictMapper : AutoMapper.Profile
    {
        public DistrictMapper()
        {
            CreateMap<Core.DistrictRegisterDto, Core.District>().ReverseMap();
            CreateMap<Core.DistrictUpdateDto, Core.District>().ReverseMap();
            CreateMap<Core.DistrictDeleteDto, Core.District>().ReverseMap();
            CreateMap<Core.DistrictSelectDto, Core.District>().ReverseMap();
        }
    }
}