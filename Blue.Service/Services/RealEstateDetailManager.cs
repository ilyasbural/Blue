namespace Blue.Service
{
	using Core;
	using AutoMapper;
	using FluentValidation;

	public class RealEstateDetailManager : BusinessObject<RealEstateDetail>, IRealEstateDetailService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<RealEstateDetail> Validator;

		public RealEstateDetailManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<RealEstateDetail> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<Response<RealEstateDetail>> InsertAsync(RealEstateDetailRegisterDto Model)
		{
			Data = Mapper.Map<RealEstateDetail>(Model);
			Data.Id = Guid.NewGuid();
			Data.RegisterDate = DateTime.Now;
			Data.UpdateDate = DateTime.Now;
			Data.IsActive = true;

			Validator.ValidateAndThrow<RealEstateDetail>(Data);
			await UnitOfWork.RealEstateDetail.InsertAsync(Data);
			int Success = await UnitOfWork.SaveChangesAsync();

			return new Response<RealEstateDetail>
			{
				Success = 1,
				Data = Data,
				Message = "Success",
				IsValidationError = false
			};
		}

		public async Task<Response<RealEstateDetail>> UpdateAsync(RealEstateDetailUpdateDto Model)
		{
			Collection = await UnitOfWork.RealEstateDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			await UnitOfWork.RealEstateDetail.UpdateAsync(Collection[0]);
			Success = await UnitOfWork.SaveChangesAsync();

			return new Response<RealEstateDetail>
			{
				Success = Success,
				Message = "Success",
				Collection = Collection,
				IsValidationError = false
			};
		}

		public async Task<Response<RealEstateDetail>> DeleteAsync(RealEstateDetailDeleteDto Model)
		{
			Collection = await UnitOfWork.RealEstateDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			await UnitOfWork.RealEstateDetail.DeleteAsync(Collection[0]);
			Success = await UnitOfWork.SaveChangesAsync();

			return new Response<RealEstateDetail>
			{
				Success = Success,
				Message = "Success",
				Collection = Collection,
				IsValidationError = false
			};
		}

		public async Task<Response<RealEstateDetail>> SelectAsync(RealEstateDetailSelectDto Model)
		{
			Collection = await UnitOfWork.RealEstateDetail.SelectAsync(x => x.IsActive == true);
			return new Response<RealEstateDetail>
			{
				Success = 1,
				Message = "Success",
				Collection = Collection,
				IsValidationError = false
			};
		}

		public async Task<Response<RealEstateDetail>> SelectSingleAsync(RealEstateDetailSelectDto Model)
		{
			Collection = await UnitOfWork.RealEstateDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			return new Response<RealEstateDetail>
			{
				Success = 1,
				Message = "Success",
				Collection = Collection,
				IsValidationError = false
			};
		}
	}
}