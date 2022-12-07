namespace Blue.Business
{
    public class RealEstateDetailMapper : AutoMapper.Profile
    {
        public RealEstateDetailMapper()
        {
            CreateMap<Core.RealEstateDetailInsertDataTransfer, Core.RealEstateDetail>();
            CreateMap<Core.RealEstateDetailUpdateDataTransfer, Core.RealEstateDetail>();
            CreateMap<Core.RealEstateDetailDeleteDataTransfer, Core.RealEstateDetail>();
            CreateMap<Core.RealEstateDetailSelectDataTransfer, Core.RealEstateDetail>();
            CreateMap<Core.RealEstateDetailAnyDataTransfer, Core.RealEstateDetail>();
        }
    }
}