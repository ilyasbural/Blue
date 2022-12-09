namespace Blue.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class RealEstateDetailManager : BusinessObjectBase<RealEstateDetail>, IRealEstateDetailService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Size> Validator;

        public RealEstateDetailManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Size> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<RealEstateDetailServiceResponse> InsertAsync(RealEstateDetailInsertDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<RealEstateDetailServiceResponse> UpdateAsync(RealEstateDetailUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<RealEstateDetailServiceResponse> DeleteAsync(RealEstateDetailDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<RealEstateDetailServiceResponse> SelectAsync(RealEstateDetailSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<RealEstateDetailServiceResponse> AnySelectAsync(RealEstateDetailAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}