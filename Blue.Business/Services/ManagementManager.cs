namespace Blue.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class ManagementManager : BusinessObjectBase<Management>, IManagementService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Size> Validator;

        public ManagementManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Size> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<ManagementServiceResponse> InsertAsync(ManagementInsertDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ManagementServiceResponse> UpdateAsync(ManagementUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ManagementServiceResponse> DeleteAsync(ManagementDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ManagementServiceResponse> SelectAsync(ManagementSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<ManagementServiceResponse> AnySelectAsync(ManagementAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}