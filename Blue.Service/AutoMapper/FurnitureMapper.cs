namespace Blue.Service
{
    public class FurnitureMapper : AutoMapper.Profile
    {
        public FurnitureMapper()
        {
            CreateMap<Core.FurnitureRegisterDto, Core.Furniture>().ReverseMap();
            CreateMap<Core.FurnitureUpdateDto, Core.Furniture>().ReverseMap();
            CreateMap<Core.FurnitureDeleteDto, Core.Furniture>().ReverseMap();
            CreateMap<Core.FurnitureSelectDto, Core.Furniture>().ReverseMap();
        }
    }
}