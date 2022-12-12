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

        public async Task<RealEstateDetailServiceResponse> InsertAsync(RealEstateDetailInsertDataTransfer Model)
        {
            RealEstateDetail realEstateDetail = Mapper.Map<RealEstateDetail>(Model);
            realEstateDetail.Id = Guid.NewGuid();
            realEstateDetail.RegisterDate = DateTime.Now;
            realEstateDetail.UpdateDate = DateTime.Now;
            realEstateDetail.IsActive = true;

            await UnitOfWork.RealEstateDetail.InsertAsync(realEstateDetail);
            await UnitOfWork.SaveChangesAsync();

            return new RealEstateDetailServiceResponse { RealEstateDetail = realEstateDetail };
        }

        public async Task<RealEstateDetailServiceResponse> UpdateAsync(RealEstateDetailUpdateDataTransfer Model)
        {
            List<RealEstateDetail> DataSource = await UnitOfWork.RealEstateDetail.SelectAsync(x => x.Id == Model.Id);
            RealEstateDetail realEstateDetail = Mapper.Map<RealEstateDetail>(DataSource[0]);
            realEstateDetail.UpdateDate = DateTime.Now;

            await UnitOfWork.RealEstateDetail.UpdateAsync(realEstateDetail);
            await UnitOfWork.SaveChangesAsync();

            RealEstateDetailServiceResponse realEstateDetailServiceResponse = Mapper.Map<RealEstateDetailServiceResponse>(realEstateDetail);
            return new RealEstateDetailServiceResponse { };
        }

        public async Task<RealEstateDetailServiceResponse> DeleteAsync(RealEstateDetailDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<RealEstateDetailServiceResponse> SelectAsync(RealEstateDetailSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<RealEstateDetailServiceResponse> AnySelectAsync(RealEstateDetailAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}