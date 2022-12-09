namespace Blue.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class PriceManager : BusinessObjectBase<Price>, IPriceService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Size> Validator;

        public PriceManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Size> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<PriceServiceResponse> InsertAsync(PriceInsertDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<PriceServiceResponse> UpdateAsync(PriceUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<PriceServiceResponse> DeleteAsync(PriceDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<PriceServiceResponse> SelectAsync(PriceSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<PriceServiceResponse> AnySelectAsync(PriceAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}