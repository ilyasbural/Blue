namespace Blue.Business
{
    public class RealEstateMapper : AutoMapper.Profile
    {
        public RealEstateMapper()
        {
            CreateMap<Core.RealEstateInsertDataTransfer, Core.RealEstate>();
            CreateMap<Core.RealEstateUpdateDataTransfer, Core.RealEstate>();
            CreateMap<Core.RealEstateDeleteDataTransfer, Core.RealEstate>();
            CreateMap<Core.RealEstateSelectDataTransfer, Core.RealEstate>();
            CreateMap<Core.RealEstateAnyDataTransfer, Core.RealEstate>();
        }
    }
}