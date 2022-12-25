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

        public async Task<Response<Size>> InsertAsync(SizeInsertDataTransfer Model)
        {
            Size size = Mapper.Map<Size>(Model);
            size.Id = Guid.NewGuid();
            size.RegisterDate = DateTime.Now;
            size.UpdateDate = DateTime.Now;
            size.IsActive = true;

            await UnitOfWork.Size.InsertAsync(size);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<Size>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<Size>> UpdateAsync(SizeUpdateDataTransfer Model)
        {
            List<Size> DataSource = await UnitOfWork.Size.SelectAsync(x => x.Id == Model.Id);
            Size size = Mapper.Map<Size>(DataSource[0]);
            size.UpdateDate = DateTime.Now;

            await UnitOfWork.Size.UpdateAsync(size);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<Size>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<Size>> DeleteAsync(SizeDeleteDataTransfer Model)
        {
            List<Size> dataSource = await UnitOfWork.Size.SelectAsync(x => x.Id == Model.Id);
            Size size = Mapper.Map<Size>(dataSource[0]);

            await UnitOfWork.Size.DeleteAsync(size);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<Size>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<Size>> SelectAsync(SizeSelectDataTransfer Model)
        {
            List<Size> DataSource = await UnitOfWork.Size.SelectAsync(x => x.IsActive == true);
            return new Response<Size>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<Size>> AnySelectAsync(SizeAnyDataTransfer Model)
        {
            //SizeServiceResponse response = new SizeServiceResponse();
            await UnitOfWork.Size.SelectAsync(x => x.Id == Model.Id);
            //return response;
            return new Response<Size>
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