namespace Blue.Business
{
    public class DistrictMapper : AutoMapper.Profile
    {
        public DistrictMapper()
        {
            CreateMap<Core.DistrictInsertDataTransfer, Core.District>();
            CreateMap<Core.DistrictUpdateDataTransfer, Core.District>();
            CreateMap<Core.DistrictDeleteDataTransfer, Core.District>();
            CreateMap<Core.DistrictSelectDataTransfer, Core.District>();
            CreateMap<Core.DistrictAnyDataTransfer, Core.District>();
        }
    }
}