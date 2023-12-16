namespace Blue.Service
{
	using Core;
	using AutoMapper;
	using FluentValidation;

	public class PictureManager : BusinessObject<Picture>, IPictureService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<Picture> Validator;

		public PictureManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Picture> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<Response<Picture>> InsertAsync(PictureRegisterDto Model)
		{
			Data = Mapper.Map<Picture>(Model);
			Data.Id = Guid.NewGuid();
			Data.RegisterDate = DateTime.Now;
			Data.UpdateDate = DateTime.Now;
			Data.IsActive = true;

			Validator.ValidateAndThrow<Picture>(Data);
			await UnitOfWork.Picture.InsertAsync(Data);
			int Success = await UnitOfWork.SaveChangesAsync();

			return new Response<Picture>
			{
				Success = 1,
				Data = Data,
				Message = "Success",
				IsValidationError = false
			};
		}

		public async Task<Response<Picture>> UpdateAsync(PictureUpdateDto Model)
		{
			Collection = await UnitOfWork.Picture.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			await UnitOfWork.Picture.UpdateAsync(Collection[0]);
			Success = await UnitOfWork.SaveChangesAsync();

			return new Response<Picture>
			{
				Success = Success,
				Message = "Success",
				Collection = Collection,
				IsValidationError = false
			};
		}

		public async Task<Response<Picture>> DeleteAsync(PictureDeleteDto Model)
		{
			Collection = await UnitOfWork.Picture.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			await UnitOfWork.Picture.DeleteAsync(Collection[0]);
			Success = await UnitOfWork.SaveChangesAsync();

			return new Response<Picture>
			{
				Success = Success,
				Message = "Success",
				Collection = Collection,
				IsValidationError = false
			};
		}

		public async Task<Response<Picture>> SelectAsync(PictureSelectDto Model)
		{
			Collection = await UnitOfWork.Picture.SelectAsync(x => x.IsActive == true);
			return new Response<Picture>
			{
				Success = 1,
				Message = "Success",
				Collection = Collection,
				IsValidationError = false
			};
		}

		public async Task<Response<Picture>> SelectSingleAsync(PictureSelectDto Model)
		{
			Collection = await UnitOfWork.Picture.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			return new Response<Picture>
			{
				Success = 1,
				Message = "Success",
				Collection = Collection,
				IsValidationError = false
			};
		}
	}
}