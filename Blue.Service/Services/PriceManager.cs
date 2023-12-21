namespace Blue.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class PriceManager : BusinessObject<Price>, IPriceService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Price> Validator;

        public PriceManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Price> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<Price>> InsertAsync(PriceRegisterDto Model)
        {
            Data = Mapper.Map<Price>(Model);
            Data.Id = Guid.NewGuid();
            Data.RegisterDate = DateTime.Now;
            Data.UpdateDate = DateTime.Now;
            Data.IsActive = true;

            Validator.ValidateAndThrow<Price>(Data);
            await UnitOfWork.Price.InsertAsync(Data);
            int Success = await UnitOfWork.SaveChangesAsync();

            return new Response<Price>
            {
                Success = 1,
                Data = Data,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<Price>> UpdateAsync(PriceUpdateDto Model)
        {
            Collection = await UnitOfWork.Price.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            await UnitOfWork.Price.UpdateAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<Price>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<Price>> DeleteAsync(PriceDeleteDto Model)
        {
            Collection = await UnitOfWork.Price.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            await UnitOfWork.Price.DeleteAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<Price>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<Price>> SelectAsync(PriceSelectDto Model)
        {
            Collection = await UnitOfWork.Price.SelectAsync(x => x.IsActive == true);
            return new Response<Price>
            {
                Success = 1,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<Price>> SelectSingleAsync(PriceSelectDto Model)
        {
            Collection = await UnitOfWork.Price.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<Price>
            {
                Success = 1,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }
    }
}