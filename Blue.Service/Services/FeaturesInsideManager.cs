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
    }
}