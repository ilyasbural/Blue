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

        public async Task<RealEstateServiceResponse> InsertAsync(RealEstateInsertDataTransfer Model)
        {
            RealEstate realEstate = Mapper.Map<RealEstate>(Model);
            realEstate.Id = Guid.NewGuid();
            realEstate.RegisterDate = DateTime.Now;
            realEstate.UpdateDate = DateTime.Now;
            realEstate.IsActive = true;

            await UnitOfWork.RealEstate.InsertAsync(realEstate);
            await UnitOfWork.SaveChangesAsync();

            return new RealEstateServiceResponse { Single = realEstate };
        }

        public async Task<RealEstateServiceResponse> UpdateAsync(RealEstateUpdateDataTransfer Model)
        {
            List<RealEstate> DataSource = await UnitOfWork.RealEstate.SelectAsync(x => x.Id == Model.Id);
            RealEstate realEstate = Mapper.Map<RealEstate>(DataSource[0]);
            realEstate.UpdateDate = DateTime.Now;

            await UnitOfWork.RealEstate.UpdateAsync(realEstate);
            await UnitOfWork.SaveChangesAsync();

            return new RealEstateServiceResponse { Single = realEstate };
        }

        public async Task<RealEstateServiceResponse> DeleteAsync(RealEstateDeleteDataTransfer Model)
        {
            List<RealEstate> dataSource = await UnitOfWork.RealEstate.SelectAsync(x => x.Id == Model.Id);
            RealEstate realEstate = Mapper.Map<RealEstate>(dataSource[0]);

            await UnitOfWork.RealEstate.DeleteAsync(realEstate);
            await UnitOfWork.SaveChangesAsync();

            return new RealEstateServiceResponse {       };
        }

        public async Task<RealEstateServiceResponse> SelectAsync(RealEstateSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<RealEstateServiceResponse> AnySelectAsync(RealEstateAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}