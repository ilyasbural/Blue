namespace Blue.Business
{
    public class SizeMapper : AutoMapper.Profile
    {
        public SizeMapper()
        {
            CreateMap<Core.SizeInsertDataTransfer, Core.Size>();
            CreateMap<Core.SizeUpdateDataTransfer, Core.Size>();
            CreateMap<Core.SizeDeleteDataTransfer, Core.Size>();
            CreateMap<Core.SizeSelectDataTransfer, Core.Size>();
            CreateMap<Core.SizeAnyDataTransfer, Core.Size>();
        }
    }
}