namespace Blue.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class FurnitureManager : ServiceBase<Furniture>, IFurnitureService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Furniture> Validator;

        public FurnitureManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Furniture> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }
    }
}