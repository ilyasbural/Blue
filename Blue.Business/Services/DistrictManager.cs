namespace Blue.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class DistrictManager : BusinessObjectBase<District>, IDistrictService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Size> Validator;

        public DistrictManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Size> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<DistrictServiceResponse> InsertAsync(DistrictInsertDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<DistrictServiceResponse> UpdateAsync(DistrictUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<DistrictServiceResponse> DeleteAsync(DistrictDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<DistrictServiceResponse> SelectAsync(DistrictSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<DistrictServiceResponse> AnySelectAsync(DistrictAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}