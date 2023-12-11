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

        public async Task<Response<FeaturesOutside>> UpdateAsync(FeaturesOutsideUpdateDto Model)
        {
            Collection = await UnitOfWork.FeaturesOutside.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            await UnitOfWork.FeaturesOutside.UpdateAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<FeaturesOutside>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<FeaturesOutside>> DeleteAsync(FeaturesOutsideDeleteDto Model)
        {
            Collection = await UnitOfWork.FeaturesOutside.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            await UnitOfWork.FeaturesOutside.DeleteAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<FeaturesOutside>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<FeaturesOutside>> SelectAsync(FeaturesOutsideSelectDto Model)
        {
            Collection = await UnitOfWork.FeaturesOutside.SelectAsync(x => x.IsActive == true);
            return new Response<FeaturesOutside>
            {
                Success = 1,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<FeaturesOutside>> SelectSingleAsync(FeaturesOutsideSelectDto Model)
        {
            Collection = await UnitOfWork.FeaturesOutside.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<FeaturesOutside>
            {
                Success = 1,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }
    }
}