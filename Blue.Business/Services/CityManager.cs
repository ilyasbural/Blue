namespace Blue.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class CityManager : BusinessObjectBase<City>, ICityService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Size> Validator;

        public CityManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Size> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<CityServiceResponse> InsertAsync(CityInsertDataTransfer Model)
        {
            City city = Mapper.Map<City>(Model);
            city.Id = Guid.NewGuid();
            city.RegisterDate = DateTime.Now;
            city.UpdateDate = DateTime.Now;
            city.IsActive = true;

            await UnitOfWork.City.InsertAsync(city);
            await UnitOfWork.SaveChangesAsync();

            return new CityServiceResponse { City = city };
        }

        public async Task<CityServiceResponse> UpdateAsync(CityUpdateDataTransfer Model)
        {
            List<City> DataSource = await UnitOfWork.City.SelectAsync(x => x.Id == Model.Id);
            City city = Mapper.Map<City>(DataSource[0]);
            city.UpdateDate = DateTime.Now;

            await UnitOfWork.City.UpdateAsync(city);
            await UnitOfWork.SaveChangesAsync();

            CityServiceResponse cityResponse = Mapper.Map<CityServiceResponse>(city);
            return new CityServiceResponse { };
        }

        public async Task<CityServiceResponse> DeleteAsync(CityDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<CityServiceResponse> SelectAsync(CitySelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<CityServiceResponse> AnySelectAsync(CityAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}