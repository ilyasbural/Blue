namespace Blue.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class PriceManager : BusinessObjectBase<Price>, IPriceService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Size> Validator;

        public PriceManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Size> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<Price>> InsertAsync(PriceInsertDataTransfer Model)
        {
            Price price = Mapper.Map<Price>(Model);
            price.Id = Guid.NewGuid();
            price.RegisterDate = DateTime.Now;
            price.UpdateDate = DateTime.Now;
            price.IsActive = true;

            await UnitOfWork.Price.InsertAsync(price);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<Price>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<Price>> UpdateAsync(PriceUpdateDataTransfer Model)
        {
            List<Price> DataSource = await UnitOfWork.Price.SelectAsync(x => x.Id == Model.Id);
            Price price = Mapper.Map<Price>(DataSource[0]);
            price.UpdateDate = DateTime.Now;

            await UnitOfWork.Price.UpdateAsync(price);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<Price>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<Price>> DeleteAsync(PriceDeleteDataTransfer Model)
        {
            List<Price> dataSource = await UnitOfWork.Price.SelectAsync(x => x.Id == Model.Id);
            Price price = Mapper.Map<Price>(dataSource[0]);

            await UnitOfWork.Price.DeleteAsync(price);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<Price>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<Price>> SelectAsync(PriceSelectDataTransfer Model)
        {
            List<Price> DataSource = await UnitOfWork.Price.SelectAsync(x => x.IsActive == true);
            return new Response<Price>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<Price>> AnySelectAsync(PriceAnyDataTransfer Model)
        {
            //PriceServiceResponse response = new PriceServiceResponse();
            await UnitOfWork.Price.SelectAsync(x => x.Id == Model.Id);
            //return response;
            return new Response<Price>
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