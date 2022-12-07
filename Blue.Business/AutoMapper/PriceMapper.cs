namespace Blue.Business
{
    public class PriceMapper : AutoMapper.Profile
    {
        public PriceMapper()
        {
            CreateMap<Core.PriceInsertDataTransfer, Core.Price>();
            CreateMap<Core.PriceUpdateDataTransfer, Core.Price>();
            CreateMap<Core.PriceDeleteDataTransfer, Core.Price>();
            CreateMap<Core.PriceSelectDataTransfer, Core.Price>();
            CreateMap<Core.PriceAnyDataTransfer, Core.Price>();
        }
    }
}