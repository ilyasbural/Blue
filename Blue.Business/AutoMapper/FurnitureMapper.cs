namespace Blue.Business
{
    public class FurnitureMapper : AutoMapper.Profile
    {
        public FurnitureMapper()
        {
            CreateMap<Core.FurnitureInsertDataTransfer, Core.Furniture>();
            CreateMap<Core.FurnitureUpdateDataTransfer, Core.Furniture>();
            CreateMap<Core.FurnitureDeleteDataTransfer, Core.Furniture>();
            CreateMap<Core.FurnitureSelectDataTransfer, Core.Furniture>();
            CreateMap<Core.FurnitureAnyDataTransfer, Core.Furniture>();
        }
    }
}