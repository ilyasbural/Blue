namespace Blue.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class FeaturesInsideManager : BusinessObject<FeaturesInside>, IFeaturesInsideService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<FeaturesInside> Validator;

        public FeaturesInsideManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<FeaturesInside> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<FeaturesInside>> InsertAsync(FeaturesInsideRegisterDto Model)
        {
            Data = Mapper.Map<FeaturesInside>(Model);
            Data.Id = Guid.NewGuid();
            Data.RegisterDate = DateTime.Now;
            Data.UpdateDate = DateTime.Now;
            Data.IsActive = true;

            Validator.ValidateAndThrow<FeaturesInside>(Data);
            await UnitOfWork.FeaturesInside.InsertAsync(Data);
            int Success = await UnitOfWork.SaveChangesAsync();

            return new Response<FeaturesInside>
            {
                Success = Success,
                Data = Data,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<FeaturesInside>> UpdateAsync(FeaturesInsideUpdateDto Model)
        {
            Collection = await UnitOfWork.FeaturesInside.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            await UnitOfWork.FeaturesInside.UpdateAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<FeaturesInside>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<FeaturesInside>> DeleteAsync(FeaturesInsideDeleteDto Model)
        {
            Collection = await UnitOfWork.FeaturesInside.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            await UnitOfWork.FeaturesInside.DeleteAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<FeaturesInside>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }
    }
}