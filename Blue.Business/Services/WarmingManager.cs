namespace Blue.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class WarmingManager : BusinessObjectBase<Warming>, IWarmingService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Size> Validator;

        public WarmingManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Size> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<WarmingServiceResponse> InsertAsync(WarmingInsertDataTransfer Model)
        {
            Warming warming = Mapper.Map<Warming>(Model);
            warming.Id = Guid.NewGuid();
            warming.RegisterDate = DateTime.Now;
            warming.UpdateDate = DateTime.Now;
            warming.IsActive = true;

            await UnitOfWork.Warming.InsertAsync(warming);
            await UnitOfWork.SaveChangesAsync();

            return new WarmingServiceResponse { Single = warming };
        }

        public async Task<WarmingServiceResponse> UpdateAsync(WarmingUpdateDataTransfer Model)
        {
            List<Warming> DataSource = await UnitOfWork.Warming.SelectAsync(x => x.Id == Model.Id);
            Warming warming = Mapper.Map<Warming>(DataSource[0]);
            warming.UpdateDate = DateTime.Now;

            await UnitOfWork.Warming.UpdateAsync(warming);
            await UnitOfWork.SaveChangesAsync();

            return new WarmingServiceResponse { Single = warming };
        }

        public async Task<WarmingServiceResponse> DeleteAsync(WarmingDeleteDataTransfer Model)
        {
            List<Warming> dataSource = await UnitOfWork.Warming.SelectAsync(x => x.Id == Model.Id);
            Warming warming = Mapper.Map<Warming>(dataSource[0]);

            await UnitOfWork.Warming.DeleteAsync(warming);
            await UnitOfWork.SaveChangesAsync();

            return new WarmingServiceResponse {      };
        }

        public async Task<WarmingServiceResponse> SelectAsync(WarmingSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<WarmingServiceResponse> AnySelectAsync(WarmingAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}