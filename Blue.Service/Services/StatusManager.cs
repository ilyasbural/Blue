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
    }
}