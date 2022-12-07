namespace Blue.Business
{
    public class WarmingMapper : AutoMapper.Profile
    {
        public WarmingMapper()
        {
            CreateMap<Core.WarmingInsertDataTransfer, Core.Warming>();
            CreateMap<Core.WarmingUpdateDataTransfer, Core.Warming>();
            CreateMap<Core.WarmingDeleteDataTransfer, Core.Warming>();
            CreateMap<Core.WarmingSelectDataTransfer, Core.Warming>();
            CreateMap<Core.WarmingAnyDataTransfer, Core.Warming>();
        }
    }
}