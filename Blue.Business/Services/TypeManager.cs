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
            int result = await UnitOfWork.SaveChangesAsync();

            return new TypeServiceResponse 
            { 
                Single = type, 
                Success = result 
            };
        }

        public async Task<TypeServiceResponse> UpdateAsync(TypeUpdateDataTransfer Model)
        {
            List<Type> DataSource = await UnitOfWork.Type.SelectAsync(x => x.Id == Model.Id);
            Type type = Mapper.Map<Type>(DataSource[0]);
            type.UpdateDate = DateTime.Now;

            await UnitOfWork.Type.UpdateAsync(type);
            int result = await UnitOfWork.SaveChangesAsync();

            return new TypeServiceResponse
            {
                Single = type,
                Success = result
            };
        }

        public async Task<TypeServiceResponse> DeleteAsync(TypeDeleteDataTransfer Model)
        {
            List<Type> dataSource = await UnitOfWork.Type.SelectAsync(x => x.Id == Model.Id);
            Type type = Mapper.Map<Type>(dataSource[0]);

            await UnitOfWork.Type.DeleteAsync(type);
            int result = await UnitOfWork.SaveChangesAsync();

            return new TypeServiceResponse
            {
                Success = result
            };
        }

        public async Task<TypeServiceResponse> SelectAsync(TypeSelectDataTransfer Model)
        {
            List<Type> DataSource = await UnitOfWork.Type.SelectAsync(x => x.IsActive == true);
            return new TypeServiceResponse { List = DataSource };
        }

        public async Task<TypeServiceResponse> AnySelectAsync(TypeAnyDataTransfer Model)
        {
            TypeServiceResponse response = new TypeServiceResponse();
            response.IsAvailable = await UnitOfWork.Type.AnySelectAsync(x => x.Id == Model.Id);
            return response;
        }
    }
}