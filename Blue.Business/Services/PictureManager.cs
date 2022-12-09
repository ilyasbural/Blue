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
            throw new NotImplementedException();
        }

        public async Task<PictureServiceResponse> UpdateAsync(PictureUpdateDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<PictureServiceResponse> DeleteAsync(PictureDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
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