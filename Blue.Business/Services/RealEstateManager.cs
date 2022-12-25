namespace Blue.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class RealEstateManager : BusinessObjectBase<RealEstate>, IRealEstateService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Size> Validator;

        public RealEstateManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Size> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<RealEstate>> InsertAsync(RealEstateInsertDataTransfer Model)
        {
            RealEstate realEstate = Mapper.Map<RealEstate>(Model);
            realEstate.Id = Guid.NewGuid();
            realEstate.RegisterDate = DateTime.Now;
            realEstate.UpdateDate = DateTime.Now;
            realEstate.IsActive = true;

            await UnitOfWork.RealEstate.InsertAsync(realEstate);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<RealEstate>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<RealEstate>> UpdateAsync(RealEstateUpdateDataTransfer Model)
        {
            List<RealEstate> DataSource = await UnitOfWork.RealEstate.SelectAsync(x => x.Id == Model.Id);
            RealEstate realEstate = Mapper.Map<RealEstate>(DataSource[0]);
            realEstate.UpdateDate = DateTime.Now;

            await UnitOfWork.RealEstate.UpdateAsync(realEstate);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<RealEstate>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<RealEstate>> DeleteAsync(RealEstateDeleteDataTransfer Model)
        {
            List<RealEstate> dataSource = await UnitOfWork.RealEstate.SelectAsync(x => x.Id == Model.Id);
            RealEstate realEstate = Mapper.Map<RealEstate>(dataSource[0]);

            await UnitOfWork.RealEstate.DeleteAsync(realEstate);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<RealEstate>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<RealEstate>> SelectAsync(RealEstateSelectDataTransfer Model)
        {
            List<RealEstate> DataSource = await UnitOfWork.RealEstate.SelectAsync(x => x.IsActive == true);
            return new Response<RealEstate>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<RealEstate>> AnySelectAsync(RealEstateAnyDataTransfer Model)
        {
            //RealEstateServiceResponse response = new RealEstateServiceResponse();
            await UnitOfWork.RealEstate.SelectAsync(x => x.Id == Model.Id);
            //return response;
            return new Response<RealEstate>
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