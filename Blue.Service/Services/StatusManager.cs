namespace Blue.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class StatusManager : BusinessObject<Status>, IStatusService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Status> Validator;

        public StatusManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Status> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        } 

        public async Task<Response<Status>> InsertAsync(StatusRegisterDto Model)
        {
            Data = Mapper.Map<Status>(Model);
            Data.Id = Guid.NewGuid();
            Data.RegisterDate = DateTime.Now;
            Data.UpdateDate = DateTime.Now;
            Data.IsActive = true;

            Validator.ValidateAndThrow<Status>(Data);
            await UnitOfWork.Status.InsertAsync(Data);
            int Success = await UnitOfWork.SaveChangesAsync();

            return new Response<Status>
            {
                Success = Success,
                Data = Data,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<Status>> UpdateAsync(StatusUpdateDto Model)
        {
            Collection = await UnitOfWork.Status.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            await UnitOfWork.Status.UpdateAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<Status>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<Status>> DeleteAsync(StatusDeleteDto Model)
        {
            Collection = await UnitOfWork.Status.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            await UnitOfWork.Status.DeleteAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<Status>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<Status>> SelectAsync(StatusSelectDto Model)
        {
            Collection = await UnitOfWork.Status.SelectAsync(x => x.IsActive == true);
            return new Response<Status>
            {
                Success = 1,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }
    }
}