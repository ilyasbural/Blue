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
            Type type = Mapper.Map<Type>(Model);
            type.Id = Guid.NewGuid();
            type.RegisterDate = DateTime.Now;
            type.UpdateDate = DateTime.Now;
            type.IsActive = true;

            await UnitOfWork.Type.InsertAsync(type);
            await UnitOfWork.SaveChangesAsync();

            return new TypeServiceResponse { Type = type };
        }

        public async Task<TypeServiceResponse> UpdateAsync(TypeUpdateDataTransfer Model)
        {
            List<Type> DataSource = await UnitOfWork.Type.SelectAsync(x => x.Id == Model.Id);
            Type type = Mapper.Map<Type>(DataSource[0]);
            type.UpdateDate = DateTime.Now;

            await UnitOfWork.Type.UpdateAsync(type);
            await UnitOfWork.SaveChangesAsync();

            TypeServiceResponse typeServiceResponse = Mapper.Map<TypeServiceResponse>(type);
            return new TypeServiceResponse {   };
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