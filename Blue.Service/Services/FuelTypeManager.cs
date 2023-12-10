namespace Blue.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class FuelTypeManager : BusinessObject<FuelType>, IFuelTypeService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<FuelType> Validator;

        public FuelTypeManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<FuelType> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }
    }
}