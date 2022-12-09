namespace Blue.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class WarmingManager : BusinessObjectBase<Warming>, IWarmingService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Size> Validator;

        public WarmingManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Size> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<WarmingServiceResponse> InsertAsync(WarmingInsertDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<WarmingServiceResponse> UpdateAsync(WarmingUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<WarmingServiceResponse> DeleteAsync(WarmingDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<WarmingServiceResponse> SelectAsync(WarmingSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<WarmingServiceResponse> AnySelectAsync(WarmingAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}