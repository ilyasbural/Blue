namespace Blue.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class BuildingTypeManager : BusinessObject<BuildingType>, IBuildingTypeService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<BuildingType> Validator;

        public BuildingTypeManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<BuildingType> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }
    }
}