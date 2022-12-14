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

            return new CityServiceResponse { Single = city };
        }

        public async Task<CityServiceResponse> UpdateAsync(CityUpdateDataTransfer Model)
        {
            List<City> DataSource = await UnitOfWork.City.SelectAsync(x => x.Id == Model.Id);
            City city = Mapper.Map<City>(DataSource[0]);
            city.UpdateDate = DateTime.Now;

            await UnitOfWork.City.UpdateAsync(city);
            await UnitOfWork.SaveChangesAsync();

            return new CityServiceResponse { Single = city };
        }

        public async Task<CityServiceResponse> DeleteAsync(CityDeleteDataTransfer Model)
        {
            List<City> dataSource = await UnitOfWork.City.SelectAsync(x => x.Id == Model.Id);
            City city = Mapper.Map<City>(dataSource[0]);

            await UnitOfWork.City.DeleteAsync(city);
            await UnitOfWork.SaveChangesAsync();

            CityServiceResponse Response = Mapper.Map<CityServiceResponse>(city);
            return new CityServiceResponse {    };
        }

        public async Task<CityServiceResponse> SelectAsync(CitySelectDataTransfer Model)
        {
            List<City> DataSource = await UnitOfWork.City.SelectAsync(x => x.IsActive == true);
            return new CityServiceResponse { List = DataSource };
        }

        public async Task<CityServiceResponse> AnySelectAsync(CityAnyDataTransfer Model)
        {
            CityServiceResponse Response = new CityServiceResponse();
            await UnitOfWork.City.AnySelectAsync(x => x.Id == Model.Id);
            //Response.IsAvailable = await UnitOfWork.City.AnyAsync(x => x.Id == Model.Id);
            //Response.Message = "Found";
            //Response.IsSuccess = true;
            return Response;
        }
    }
}