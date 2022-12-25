namespace Blue.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class RealEstateDetailManager : BusinessObjectBase<RealEstateDetail>, IRealEstateDetailService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Size> Validator;

        public RealEstateDetailManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Size> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<RealEstateDetail>> InsertAsync(RealEstateDetailInsertDataTransfer Model)
        {
            RealEstateDetail realEstateDetail = Mapper.Map<RealEstateDetail>(Model);
            realEstateDetail.Id = Guid.NewGuid();
            realEstateDetail.RegisterDate = DateTime.Now;
            realEstateDetail.UpdateDate = DateTime.Now;
            realEstateDetail.IsActive = true;

            await UnitOfWork.RealEstateDetail.InsertAsync(realEstateDetail);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<RealEstateDetail>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<RealEstateDetail>> UpdateAsync(RealEstateDetailUpdateDataTransfer Model)
        {
            List<RealEstateDetail> DataSource = await UnitOfWork.RealEstateDetail.SelectAsync(x => x.Id == Model.Id);
            RealEstateDetail realEstateDetail = Mapper.Map<RealEstateDetail>(DataSource[0]);
            realEstateDetail.UpdateDate = DateTime.Now;

            await UnitOfWork.RealEstateDetail.UpdateAsync(realEstateDetail);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<RealEstateDetail>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<RealEstateDetail>> DeleteAsync(RealEstateDetailDeleteDataTransfer Model)
        {
            List<RealEstateDetail> dataSource = await UnitOfWork.RealEstateDetail.SelectAsync(x => x.Id == Model.Id);
            RealEstateDetail realEstateDetail = Mapper.Map<RealEstateDetail>(dataSource[0]);

            await UnitOfWork.RealEstateDetail.DeleteAsync(realEstateDetail);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<RealEstateDetail>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<RealEstateDetail>> SelectAsync(RealEstateDetailSelectDataTransfer Model)
        {
            List<RealEstateDetail> DataSource = await UnitOfWork.RealEstateDetail.SelectAsync(x => x.IsActive == true);
            return new Response<RealEstateDetail>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<RealEstateDetail>> AnySelectAsync(RealEstateDetailAnyDataTransfer Model)
        {
            //RealEstateDetailServiceResponse response = new RealEstateDetailServiceResponse();
            await UnitOfWork.RealEstateDetail.SelectAsync(x => x.Id == Model.Id);
            //return response;
            return new Response<RealEstateDetail>
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