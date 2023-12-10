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
    }
}