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

        public async Task<Response<Type>> InsertAsync(TypeInsertDataTransfer Model)
        {
            Type type = Mapper.Map<Type>(Model);
            type.Id = Guid.NewGuid();
            type.RegisterDate = DateTime.Now;
            type.UpdateDate = DateTime.Now;
            type.IsActive = true;

            await UnitOfWork.Type.InsertAsync(type);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<Type>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<Type>> UpdateAsync(TypeUpdateDataTransfer Model)
        {
            List<Type> DataSource = await UnitOfWork.Type.SelectAsync(x => x.Id == Model.Id);
            Type type = Mapper.Map<Type>(DataSource[0]);
            type.UpdateDate = DateTime.Now;

            await UnitOfWork.Type.UpdateAsync(type);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<Type>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<Type>> DeleteAsync(TypeDeleteDataTransfer Model)
        {
            List<Type> dataSource = await UnitOfWork.Type.SelectAsync(x => x.Id == Model.Id);
            Type type = Mapper.Map<Type>(dataSource[0]);

            await UnitOfWork.Type.DeleteAsync(type);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<Type>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<Type>> SelectAsync(TypeSelectDataTransfer Model)
        {
            List<Type> DataSource = await UnitOfWork.Type.SelectAsync(x => x.IsActive == true);
            return new Response<Type>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<Type>> AnySelectAsync(TypeAnyDataTransfer Model)
        {
            //TypeServiceResponse response = new TypeServiceResponse();
            await UnitOfWork.Type.SelectAsync(x => x.Id == Model.Id);
            //return response;
            return new Response<Type>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }
    }
}