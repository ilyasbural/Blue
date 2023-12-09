namespace Blue.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class TypeManager : BusinessObject<Type>, ITypeService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Type> Validator;

        public TypeManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Type> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<Type>> InsertAsync(TypeRegisterDto Model)
        {
            Data = Mapper.Map<Type>(Model);
            Data.Id = Guid.NewGuid();
            Data.RegisterDate = DateTime.Now;
            Data.UpdateDate = DateTime.Now;
            Data.IsActive = true;

            Validator.ValidateAndThrow<Type>(Data);
            await UnitOfWork.Type.InsertAsync(Data);
            int Success = await UnitOfWork.SaveChangesAsync();

            return new Response<Type>
            {
                Success = 1,
                Data = Data,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<Type>> UpdateAsync(TypeUpdateDto Model)
        {
            Collection = await UnitOfWork.Type.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            await UnitOfWork.Type.UpdateAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<Type>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<Type>> DeleteAsync(TypeDeleteDto Model)
        {
            Collection = await UnitOfWork.Type.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            await UnitOfWork.Type.DeleteAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<Type>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<Type>> SelectAsync(TypeSelectDto Model)
        {
            Collection = await UnitOfWork.Type.SelectAsync(x => x.IsActive == true);
            return new Response<Type>
            {
                Success = 1,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<Type>> SelectSingleAsync(TypeSelectDto Model)
        {
            Collection = await UnitOfWork.Type.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<Type>
            {
                Success = 1,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }
    }
}