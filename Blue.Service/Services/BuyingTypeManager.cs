namespace Blue.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class BuyingTypeManager : BusinessObject<BuyingType>, IBuyingTypeService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<BuyingType> Validator;

        public BuyingTypeManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<BuyingType> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<BuyingType>> InsertAsync(BuyingTypeRegisterDto Model)
        {
            Data = Mapper.Map<BuyingType>(Model);
            Data.Id = Guid.NewGuid();
            Data.RegisterDate = DateTime.Now;
            Data.UpdateDate = DateTime.Now;
            Data.IsActive = true;

            Validator.ValidateAndThrow<BuyingType>(Data);
            await UnitOfWork.BuyingType.InsertAsync(Data);
            int Success = await UnitOfWork.SaveChangesAsync();

            return new Response<BuyingType>
            {
                Success = Success,
                Data = Data,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<BuyingType>> UpdateAsync(BuyingTypeUpdateDto Model)
        {
            Collection = await UnitOfWork.BuyingType.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            await UnitOfWork.BuyingType.UpdateAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<BuyingType>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<BuyingType>> DeleteAsync(BuyingTypeDeleteDto Model)
        {
            Collection = await UnitOfWork.BuyingType.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            await UnitOfWork.BuyingType.DeleteAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<BuyingType>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<BuyingType>> SelectAsync(BuyingTypeSelectDto Model)
        {
            Collection = await UnitOfWork.BuyingType.SelectAsync(x => x.IsActive == true);
            return new Response<BuyingType>
            {
                Success = 1,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }
    }
}