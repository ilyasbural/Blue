namespace Blue.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class SizeManager : BusinessObjectBase<Size>, ISizeService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Size> Validator;

        public SizeManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Size> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<SizeServiceResponse> InsertAsync(SizeInsertDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<SizeServiceResponse> UpdateAsync(SizeUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<SizeServiceResponse> DeleteAsync(SizeDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<SizeServiceResponse> SelectAsync(SizeSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<SizeServiceResponse> AnySelectAsync(SizeAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}