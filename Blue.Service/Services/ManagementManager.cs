namespace Blue.Service
{
	using Core;
	using AutoMapper;
	using FluentValidation;

	public class ManagementManager : BusinessObject<Management>, IManagementService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<Management> Validator;

		public ManagementManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Management> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<Response<Management>> InsertAsync(ManagementRegisterDto Model)
		{
			Data = Mapper.Map<Management>(Model);
			Data.Id = Guid.NewGuid();
			Data.RegisterDate = DateTime.Now;
			Data.UpdateDate = DateTime.Now;
			Data.IsActive = true;

			Validator.ValidateAndThrow<Management>(Data);
			await UnitOfWork.Management.InsertAsync(Data);
			int Success = await UnitOfWork.SaveChangesAsync();

			return new Response<Management>
			{
				Success = 1,
				Data = Data,
				Message = "Success",
				IsValidationError = false
			};
		}

		public async Task<Response<Management>> UpdateAsync(ManagementUpdateDto Model)
		{
			Collection = await UnitOfWork.Management.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			await UnitOfWork.Management.UpdateAsync(Collection[0]);
			Success = await UnitOfWork.SaveChangesAsync();

			return new Response<Management>
			{
				Success = Success,
				Message = "Success",
				Collection = Collection,
				IsValidationError = false
			};
		}

		public async Task<Response<Management>> DeleteAsync(ManagementDeleteDto Model)
		{
			Collection = await UnitOfWork.Management.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			await UnitOfWork.Management.DeleteAsync(Collection[0]);
			Success = await UnitOfWork.SaveChangesAsync();

			return new Response<Management>
			{
				Success = Success,
				Message = "Success",
				Collection = Collection,
				IsValidationError = false
			};
		}

		public async Task<Response<Management>> SelectAsync(ManagementSelectDto Model)
		{
			Collection = await UnitOfWork.Management.SelectAsync(x => x.IsActive == true);
			return new Response<Management>
			{
				Success = 1,
				Message = "Success",
				Collection = Collection,
				IsValidationError = false
			};
		}

		public async Task<Response<Management>> SelectSingleAsync(ManagementSelectDto Model)
		{
			Collection = await UnitOfWork.Management.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			return new Response<Management>
			{
				Success = 1,
				Message = "Success",
				Collection = Collection,
				IsValidationError = false
			};
		}
	}
}