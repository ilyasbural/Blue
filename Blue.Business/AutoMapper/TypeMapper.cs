namespace Blue.Business
{
    public class TypeMapper : AutoMapper.Profile
    {
        public TypeMapper()
        {
            CreateMap<Core.TypeInsertDataTransfer, Core.Type>();
            CreateMap<Core.TypeUpdateDataTransfer, Core.Type>();
            CreateMap<Core.TypeDeleteDataTransfer, Core.Type>();
            CreateMap<Core.TypeSelectDataTransfer, Core.Type>();
            CreateMap<Core.TypeAnyDataTransfer, Core.Type>();
        }
    }
}