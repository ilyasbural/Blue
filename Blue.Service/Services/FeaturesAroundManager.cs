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
    }
}