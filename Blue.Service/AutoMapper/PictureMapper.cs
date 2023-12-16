namespace Blue.Service
{
	public class PictureMapper : AutoMapper.Profile
	{
		public PictureMapper()
		{
			CreateMap<Core.PictureRegisterDto, Core.Picture>().ReverseMap();
			CreateMap<Core.PictureUpdateDto, Core.Picture>().ReverseMap();
			CreateMap<Core.PictureDeleteDto, Core.Picture>().ReverseMap();
			CreateMap<Core.PictureSelectDto, Core.Picture>().ReverseMap();
		}
	}
}