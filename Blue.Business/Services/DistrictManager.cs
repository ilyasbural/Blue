namespace Blue.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class DistrictManager : BusinessObjectBase<District>, IDistrictService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Size> Validator;

        public DistrictManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Size> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<District>> InsertAsync(DistrictInsertDataTransfer Model)
        {
            District district = Mapper.Map<District>(Model);
            district.Id = Guid.NewGuid();
            district.RegisterDate = DateTime.Now;
            district.UpdateDate = DateTime.Now;
            district.IsActive = true;

            await UnitOfWork.District.InsertAsync(district);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<District>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<District>> UpdateAsync(DistrictUpdateDataTransfer Model)
        {
            List<District> DataSource = await UnitOfWork.District.SelectAsync(x => x.Id == Model.Id);
            District district = Mapper.Map<District>(DataSource[0]);
            district.UpdateDate = DateTime.Now;

            await UnitOfWork.District.UpdateAsync(district);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<District>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<District>> DeleteAsync(DistrictDeleteDataTransfer Model)
        {
            List<District> dataSource = await UnitOfWork.District.SelectAsync(x => x.Id == Model.Id);
            District district = Mapper.Map<District>(dataSource[0]);

            await UnitOfWork.District.DeleteAsync(district);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<District>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<District>> SelectAsync(DistrictSelectDataTransfer Model)
        {
            List<District> DataSource = await UnitOfWork.District.SelectAsync(x => x.IsActive == true);
            return new Response<District>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<District>> AnySelectAsync(DistrictAnyDataTransfer Model)
        {
            //DistrictServiceResponse response = new DistrictServiceResponse();
            await UnitOfWork.District.SelectAsync(x => x.IsActive == true);
            //return response;
            return new Response<District>
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