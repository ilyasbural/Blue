namespace Blue.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class WarmingManager : BusinessObject<Warming>, IWarmingService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Warming> Validator;

        public WarmingManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Warming> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<Warming>> InsertAsync(WarmingRegisterDto Model)
        {
            Data = Mapper.Map<Warming>(Model);
            Data.Id = Guid.NewGuid();
            Data.RegisterDate = DateTime.Now;
            Data.UpdateDate = DateTime.Now;
            Data.IsActive = true;

            Validator.ValidateAndThrow<Warming>(Data);
            await UnitOfWork.Warming.InsertAsync(Data);
            int Success = await UnitOfWork.SaveChangesAsync();

            return new Response<Warming>
            {   
                Success = 1,
                Data = Data,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<Warming>> UpdateAsync(WarmingUpdateDto Model)
        {
            Collection = await UnitOfWork.Warming.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            await UnitOfWork.Warming.UpdateAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<Warming>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<Warming>> DeleteAsync(WarmingDeleteDto Model)
        {
            Collection = await UnitOfWork.Warming.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            await UnitOfWork.Warming.DeleteAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<Warming>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<Warming>> SelectAsync(WarmingSelectDto Model)
        {
            Collection = await UnitOfWork.Warming.SelectAsync(x => x.IsActive == true);
            return new Response<Warming>
            {
                Success = 1,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<Warming>> SelectSingleAsync(WarmingSelectDto Model)
        {
            Collection = await UnitOfWork.Warming.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<Warming>
            {
                Success = 1,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }
    }
}