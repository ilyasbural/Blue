namespace Blue.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class PictureManager : BusinessObjectBase<Picture>, IPictureService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Size> Validator;

        public PictureManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Size> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<Picture>> InsertAsync(PictureInsertDataTransfer Model)
        {
            Picture picture = Mapper.Map<Picture>(Model);
            picture.Id = Guid.NewGuid();
            picture.RegisterDate = DateTime.Now;
            picture.UpdateDate = DateTime.Now;
            picture.IsActive = true;

            await UnitOfWork.Picture.InsertAsync(picture);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<Picture>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<Picture>> UpdateAsync(PictureUpdateDataTransfer Model)
        {
            List<Picture> DataSource = await UnitOfWork.Picture.SelectAsync(x => x.Id == Model.Id);
            Picture picture = Mapper.Map<Picture>(DataSource[0]);
            picture.UpdateDate = DateTime.Now;

            await UnitOfWork.Picture.UpdateAsync(picture);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<Picture>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<Picture>> DeleteAsync(PictureDeleteDataTransfer Model)
        {
            List<Picture> dataSource = await UnitOfWork.Picture.SelectAsync(x => x.Id == Model.Id);
            Picture picture = Mapper.Map<Picture>(dataSource[0]);

            await UnitOfWork.Picture.DeleteAsync(picture);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<Picture>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<Picture>> SelectAsync(PictureSelectDataTransfer Model)
        {
            List<Picture> DataSource = await UnitOfWork.Picture.SelectAsync(x => x.IsActive == true);
            return new Response<Picture>
            {
                //Single = Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        public async Task<Response<Picture>> AnySelectAsync(PictureAnyDataTransfer Model)
        {
            //PictureServiceResponse response = new PictureServiceResponse();
            await UnitOfWork.Picture.SelectAsync(x => x.Id == Model.Id);
            //return response;
            return new Response<Picture>
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