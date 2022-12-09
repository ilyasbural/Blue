namespace Blue.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class RealEstateManager : BusinessObjectBase<RealEstate>, IRealEstateService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Size> Validator;

        public RealEstateManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Size> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<RealEstateServiceResponse> InsertAsync(RealEstateInsertDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<RealEstateServiceResponse> UpdateAsync(RealEstateUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<RealEstateServiceResponse> DeleteAsync(RealEstateDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<RealEstateServiceResponse> SelectAsync(RealEstateSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<RealEstateServiceResponse> AnySelectAsync(RealEstateAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}