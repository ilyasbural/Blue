namespace Blue.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class TypeManager : BusinessObjectBase<Type>, ITypeService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Size> Validator;

        public TypeManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Size> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<TypeServiceResponse> InsertAsync(TypeInsertDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<TypeServiceResponse> UpdateAsync(TypeUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<TypeServiceResponse> DeleteAsync(TypeDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<TypeServiceResponse> SelectAsync(TypeSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<TypeServiceResponse> AnySelectAsync(TypeAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}