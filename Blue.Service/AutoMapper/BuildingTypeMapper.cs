namespace Blue.Service
{
	public class BuildingTypeMapper : AutoMapper.Profile
	{
		public BuildingTypeMapper()
		{
			CreateMap<Core.BuildingTypeRegisterDto, Core.BuildingType>().ReverseMap();
			CreateMap<Core.BuildingTypeUpdateDto, Core.BuildingType>().ReverseMap();
			CreateMap<Core.BuildingTypeDeleteDto, Core.BuildingType>().ReverseMap();
			CreateMap<Core.BuildingTypeSelectDto, Core.BuildingType>().ReverseMap();
		}
	}
}