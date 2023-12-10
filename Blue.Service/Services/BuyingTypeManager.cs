namespace Blue.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class BuyingTypeManager : BusinessObject<BuyingType>, IBuyingTypeService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<BuyingType> Validator;

        public BuyingTypeManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<BuyingType> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }
    }
}