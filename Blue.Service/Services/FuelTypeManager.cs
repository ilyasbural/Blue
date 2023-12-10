namespace Blue.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class FuelTypeManager : BusinessObject<FuelType>, IFuelTypeService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<FuelType> Validator;

        public FuelTypeManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<FuelType> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<FuelType>> InsertAsync(FuelTypeRegisterDto Model)
        {
            Data = Mapper.Map<FuelType>(Model);
            Data.Id = Guid.NewGuid();
            Data.RegisterDate = DateTime.Now;
            Data.UpdateDate = DateTime.Now;
            Data.IsActive = true;

            Validator.ValidateAndThrow<FuelType>(Data);
            await UnitOfWork.FuelType.InsertAsync(Data);
            int Success = await UnitOfWork.SaveChangesAsync();

            return new Response<FuelType>
            {
                Success = Success,
                Data = Data,
                Message = "Success",
                IsValidationError = false
            };
        }
    }
}