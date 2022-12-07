namespace Blue.Business
{
    public class PictureMapper : AutoMapper.Profile
    {
        public PictureMapper()
        {
            CreateMap<Core.PictureInsertDataTransfer, Core.Picture>();
            CreateMap<Core.PictureUpdateDataTransfer, Core.Picture>();
            CreateMap<Core.PictureDeleteDataTransfer, Core.Picture>();
            CreateMap<Core.PictureSelectDataTransfer, Core.Picture>();
            CreateMap<Core.PictureAnyDataTransfer, Core.Picture>();
        }
    }
}