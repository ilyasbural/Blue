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

        public async Task<SizeServiceResponse> InsertAsync(SizeInsertDataTransfer Model)
        {
            Size size = Mapper.Map<Size>(Model);
            size.Id = Guid.NewGuid();
            size.RegisterDate = DateTime.Now;
            size.UpdateDate = DateTime.Now;
            size.IsActive = true;

            await UnitOfWork.Size.InsertAsync(size);
            await UnitOfWork.SaveChangesAsync();

            return new SizeServiceResponse { Size = size };
        }

        public async Task<SizeServiceResponse> UpdateAsync(SizeUpdateDataTransfer Model)
        {
            List<Size> DataSource = await UnitOfWork.Size.SelectAsync(x => x.Id == Model.Id);
            Size size = Mapper.Map<Size>(DataSource[0]);
            size.UpdateDate = DateTime.Now;

            await UnitOfWork.Size.UpdateAsync(size);
            await UnitOfWork.SaveChangesAsync();

            SizeServiceResponse announceResponse = Mapper.Map<SizeServiceResponse>(size);
            return new SizeServiceResponse { };
        }

        public async Task<SizeServiceResponse> DeleteAsync(SizeDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<SizeServiceResponse> SelectAsync(SizeSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<SizeServiceResponse> AnySelectAsync(SizeAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}