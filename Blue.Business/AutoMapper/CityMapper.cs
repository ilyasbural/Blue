namespace Blue.Business
{
    public class CityMapper : AutoMapper.Profile
    {
        public CityMapper()
        {
            CreateMap<Core.CityInsertDataTransfer, Core.City>();
            CreateMap<Core.CityUpdateDataTransfer, Core.City>();
            CreateMap<Core.CityDeleteDataTransfer, Core.City>();
            CreateMap<Core.CitySelectDataTransfer, Core.City>();
            CreateMap<Core.CityAnyDataTransfer, Core.City>();
        }
    }
}