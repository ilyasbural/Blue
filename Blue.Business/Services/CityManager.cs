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
            throw new NotImplementedException();
        }

        public async Task<CityServiceResponse> UpdateAsync(CityUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
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