namespace Blue.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class FeaturesOutsideManager : BusinessObject<FeaturesOutside>, IFeaturesOutsideService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<FeaturesOutside> Validator;

        public FeaturesOutsideManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<FeaturesOutside> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<FeaturesOutside>> InsertAsync(FeaturesOutsideRegisterDto Model)
        {
            Data = Mapper.Map<FeaturesOutside>(Model);
            Data.Id = Guid.NewGuid();
            Data.RegisterDate = DateTime.Now;
            Data.UpdateDate = DateTime.Now;
            Data.IsActive = true;

            Validator.ValidateAndThrow<FeaturesOutside>(Data);
            await UnitOfWork.FeaturesOutside.InsertAsync(Data);
            int Success = await UnitOfWork.SaveChangesAsync();

            return new Response<FeaturesOutside>
            {
                Success = Success,
                Data = Data,
                Message = "Success",
                IsValidationError = false
            };
        }
    }
}