namespace Blue.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class FurnitureManager : BusinessObjectBase<Furniture>, IFurnitureService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Size> Validator;

        public FurnitureManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Size> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<FurnitureServiceResponse> InsertAsync(FurnitureInsertDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<FurnitureServiceResponse> UpdateAsync(FurnitureUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<FurnitureServiceResponse> DeleteAsync(FurnitureDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<FurnitureServiceResponse> SelectAsync(FurnitureSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<FurnitureServiceResponse> AnySelectAsync(FurnitureAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}