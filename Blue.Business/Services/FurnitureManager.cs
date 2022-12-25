namespace Blue.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class FurnitureManager : BusinessObjectBase<Furniture>, IFurnitureService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Size> Validator;

        public FurnitureManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Size> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<Furniture>> InsertAsync(FurnitureInsertDataTransfer Model)
        {
            Furniture furniture = Mapper.Map<Furniture>(Model);
            furniture.Id = Guid.NewGuid();
            furniture.RegisterDate = DateTime.Now;
            furniture.UpdateDate = DateTime.Now;
            furniture.IsActive = true;

            await UnitOfWork.Furniture.InsertAsync(furniture);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<Furniture>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<Furniture>> UpdateAsync(FurnitureUpdateDataTransfer Model)
        {
            List<Furniture> DataSource = await UnitOfWork.Furniture.SelectAsync(x => x.Id == Model.Id);
            Furniture furniture = Mapper.Map<Furniture>(DataSource[0]);
            furniture.UpdateDate = DateTime.Now;

            await UnitOfWork.Furniture.UpdateAsync(furniture);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<Furniture>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<Furniture>> DeleteAsync(FurnitureDeleteDataTransfer Model)
        {
            List<Furniture> dataSource = await UnitOfWork.Furniture.SelectAsync(x => x.Id == Model.Id);
            Furniture furniture = Mapper.Map<Furniture>(dataSource[0]);

            await UnitOfWork.Furniture.DeleteAsync(furniture);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<Furniture>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<Furniture>> SelectAsync(FurnitureSelectDataTransfer Model)
        {
            List<Furniture> DataSource = await UnitOfWork.Furniture.SelectAsync(x => x.IsActive == true);
            return new Response<Furniture>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<Furniture>> AnySelectAsync(FurnitureAnyDataTransfer Model)
        {
            //FurnitureServiceResponse response = new FurnitureServiceResponse();
            await UnitOfWork.Furniture.SelectAsync(x => x.Id == Model.Id);
            //return response;
            return new Response<Furniture>
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