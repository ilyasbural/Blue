namespace Blue.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class HometownManager : BusinessObject<Hometown>, IHometownService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Hometown> Validator;

        public HometownManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Hometown> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }
    }
}