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

        public async Task<Response<Management>> InsertAsync(ManagementInsertDataTransfer Model)
        {
            Management management = Mapper.Map<Management>(Model);
            management.Id = Guid.NewGuid();
            management.RegisterDate = DateTime.Now;
            management.UpdateDate = DateTime.Now;
            management.IsActive = true;

            await UnitOfWork.Management.InsertAsync(management);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<Management>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<Management>> UpdateAsync(ManagementUpdateDataTransfer Model)
        {
            List<Management> DataSource = await UnitOfWork.Management.SelectAsync(x => x.Id == Model.Id);
            Management management = Mapper.Map<Management>(DataSource[0]);
            management.UpdateDate = DateTime.Now;

            await UnitOfWork.Management.UpdateAsync(management);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<Management>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<Management>> DeleteAsync(ManagementDeleteDataTransfer Model)
        {
            List<Management> dataSource = await UnitOfWork.Management.SelectAsync(x => x.Id == Model.Id);
            Management management = Mapper.Map<Management>(dataSource[0]);

            await UnitOfWork.Management.DeleteAsync(management);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<Management>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<Management>> SelectAsync(ManagementSelectDataTransfer Model)
        {
            List<Management> DataSource = await UnitOfWork.Management.SelectAsync(x => x.IsActive == true);
            return new Response<Management>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<Management>> AnySelectAsync(ManagementAnyDataTransfer Model)
        {
            //ManagementServiceResponse response = new ManagementServiceResponse();
            await UnitOfWork.Management.SelectAsync(x => x.Id == Model.Id);
            //return response;
            return new Response<Management>
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