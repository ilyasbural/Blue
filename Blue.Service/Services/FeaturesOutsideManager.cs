namespace Blue.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class FeaturesOutsideManager : BusinessObject<FeaturesOutside>, IFeaturesOutsideService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<FeaturesOutside> Validator;

        public FeaturesOutsideManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<FeaturesOutside> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }
    }
}