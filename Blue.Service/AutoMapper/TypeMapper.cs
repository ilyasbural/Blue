namespace Blue.Service
{
    public class TypeMapper : AutoMapper.Profile
    {
        public TypeMapper()
        {
            CreateMap<Core.TypeRegisterDto, Core.Type>().ReverseMap();
            CreateMap<Core.TypeUpdateDto, Core.Type>().ReverseMap();
            CreateMap<Core.TypeDeleteDto, Core.Type>().ReverseMap();
            CreateMap<Core.TypeSelectDto, Core.Type>().ReverseMap();
        }
    }
}