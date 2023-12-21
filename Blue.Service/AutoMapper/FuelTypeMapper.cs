namespace Blue.Service
{
    public class FuelTypeMapper : AutoMapper.Profile
    {
        public FuelTypeMapper()
        {
            CreateMap<Core.FuelTypeRegisterDto, Core.FuelType>().ReverseMap();
            CreateMap<Core.FuelTypeUpdateDto, Core.FuelType>().ReverseMap();
            CreateMap<Core.FuelTypeDeleteDto, Core.FuelType>().ReverseMap();
            CreateMap<Core.FuelTypeSelectDto, Core.FuelType>().ReverseMap();
        }
    }
}