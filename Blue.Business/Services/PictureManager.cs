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

        public async Task<PictureServiceResponse> InsertAsync(PictureInsertDataTransfer Model)
        {
            Picture picture = Mapper.Map<Picture>(Model);
            picture.Id = Guid.NewGuid();
            picture.RegisterDate = DateTime.Now;
            picture.UpdateDate = DateTime.Now;
            picture.IsActive = true;

            await UnitOfWork.Picture.InsertAsync(picture);
            await UnitOfWork.SaveChangesAsync();

            return new PictureServiceResponse { Single = picture };
        }

        public async Task<PictureServiceResponse> UpdateAsync(PictureUpdateDataTransfer Model)
        {
            List<Picture> DataSource = await UnitOfWork.Picture.SelectAsync(x => x.Id == Model.Id);
            Picture picture = Mapper.Map<Picture>(DataSource[0]);
            picture.UpdateDate = DateTime.Now;

            await UnitOfWork.Picture.UpdateAsync(picture);
            await UnitOfWork.SaveChangesAsync();

            return new PictureServiceResponse { Single = picture };
        }

        public async Task<PictureServiceResponse> DeleteAsync(PictureDeleteDataTransfer Model)
        {
            List<Picture> dataSource = await UnitOfWork.Picture.SelectAsync(x => x.Id == Model.Id);
            Picture picture = Mapper.Map<Picture>(dataSource[0]);

            await UnitOfWork.Picture.DeleteAsync(picture);
            await UnitOfWork.SaveChangesAsync();

            return new PictureServiceResponse {          };
        }

        public async Task<PictureServiceResponse> SelectAsync(PictureSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<PictureServiceResponse> AnySelectAsync(PictureAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}