namespace Blue.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class FromWhoManager : BusinessObject<FromWho>, IFromWhoService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<FromWho> Validator;

        public FromWhoManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<FromWho> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }
    }
}