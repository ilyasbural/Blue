namespace Blue.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class CityManager : ServiceBase<City>, ICityService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<City> Validator;

        public CityManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<City> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<CityServiceResponse> AddAsync(CityInsertDataTransfer Model)
        {
            City city = Mapper.Map<City>(Model);
            city.RegisterDate = DateTime.Now;
            city.UpdateDate = DateTime.Now;
            city.IsActive = true;

            await UnitOfWork.City.AddAsync(city);
            await UnitOfWork.SaveChangesAsync();

            return new CityServiceResponse {  };
        }
    }
}