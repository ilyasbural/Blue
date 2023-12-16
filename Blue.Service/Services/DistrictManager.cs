namespace Blue.Service
{
	using Core;
	using AutoMapper;
	using FluentValidation;

	public class DistrictManager : BusinessObject<District>, IDistrictService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<District> Validator;

		public DistrictManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<District> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<Response<District>> InsertAsync(DistrictRegisterDto Model)
		{
			Data = Mapper.Map<District>(Model);
			Data.Id = Guid.NewGuid();
			Data.RegisterDate = DateTime.Now;
			Data.UpdateDate = DateTime.Now;
			Data.IsActive = true;

			Validator.ValidateAndThrow<District>(Data);
			await UnitOfWork.District.InsertAsync(Data);
			int Success = await UnitOfWork.SaveChangesAsync();

			return new Response<District>
			{
				Success = Success,
				Data = Data,
				Message = "Success",
				IsValidationError = false
			};
		}

		public async Task<Response<District>> UpdateAsync(DistrictUpdateDto Model)
		{
			Collection = await UnitOfWork.District.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			await UnitOfWork.District.UpdateAsync(Collection[0]);
			Success = await UnitOfWork.SaveChangesAsync();

			return new Response<District>
			{
				Success = Success,
				Message = "Success",
				Collection = Collection,
				IsValidationError = false
			};
		}

		public async Task<Response<District>> DeleteAsync(DistrictDeleteDto Model)
		{
			Collection = await UnitOfWork.District.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			await UnitOfWork.District.DeleteAsync(Collection[0]);
			Success = await UnitOfWork.SaveChangesAsync();

			return new Response<District>
			{
				Success = Success,
				Message = "Success",
				Collection = Collection,
				IsValidationError = false
			};
		}

		public async Task<Response<District>> SelectAsync(DistrictSelectDto Model)
		{
			Collection = await UnitOfWork.District.SelectAsync(x => x.IsActive == true);
			return new Response<District>
			{
				Success = 1,
				Message = "Success",
				Collection = Collection,
				IsValidationError = false
			};
		}

		public async Task<Response<District>> SelectSingleAsync(DistrictSelectDto Model)
		{
			Collection = await UnitOfWork.District.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			return new Response<District>
			{
				Success = 1,
				Message = "Success",
				Collection = Collection,
				IsValidationError = false
			};
		}
	}
}