namespace Blue.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class FeaturesAroundManager : BusinessObject<FeaturesAround>, IFeaturesAroundService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<FeaturesAround> Validator;

        public FeaturesAroundManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<FeaturesAround> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<FeaturesAround>> InsertAsync(FeaturesAroundRegisterDto Model)
        {
            Data = Mapper.Map<FeaturesAround>(Model);
            Data.Id = Guid.NewGuid();
            Data.RegisterDate = DateTime.Now;
            Data.UpdateDate = DateTime.Now;
            Data.IsActive = true;

            Validator.ValidateAndThrow<FeaturesAround>(Data);
            await UnitOfWork.FeaturesAround.InsertAsync(Data);
            int Success = await UnitOfWork.SaveChangesAsync();

            return new Response<FeaturesAround>
            {
                Success = Success,
                Data = Data,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<FeaturesAround>> UpdateAsync(FeaturesAroundUpdateDto Model)
        {
            Collection = await UnitOfWork.FeaturesAround.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            await UnitOfWork.FeaturesAround.UpdateAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<FeaturesAround>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<FeaturesAround>> DeleteAsync(FeaturesAroundDeleteDto Model)
        {
            Collection = await UnitOfWork.FeaturesAround.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            await UnitOfWork.FeaturesAround.DeleteAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<FeaturesAround>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<FeaturesAround>> SelectAsync(FeaturesAroundSelectDto Model)
        {
            Collection = await UnitOfWork.FeaturesAround.SelectAsync(x => x.IsActive == true);
            return new Response<FeaturesAround>
            {
                Success = 1,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }
    }
}