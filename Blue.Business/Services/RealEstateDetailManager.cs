namespace Blue.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class RealEstateDetailManager : ServiceBase<RealEstateDetail>, IRealEstateDetailService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<RealEstateDetail> Validator;

        public RealEstateDetailManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<RealEstateDetail> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }
    }
}