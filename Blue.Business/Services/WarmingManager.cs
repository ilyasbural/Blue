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
            int result = await UnitOfWork.SaveChangesAsync();

            return new WarmingServiceResponse 
            { 
                Single = warming, 
                Success = result 
            };
        }

        public async Task<WarmingServiceResponse> UpdateAsync(WarmingUpdateDataTransfer Model)
        {
            List<Warming> DataSource = await UnitOfWork.Warming.SelectAsync(x => x.Id == Model.Id);
            Warming warming = Mapper.Map<Warming>(DataSource[0]);
            warming.UpdateDate = DateTime.Now;

            await UnitOfWork.Warming.UpdateAsync(warming);
            int result = await UnitOfWork.SaveChangesAsync();

            return new WarmingServiceResponse
            {
                Single = warming,
                Success = result
            };
        }

        public async Task<WarmingServiceResponse> DeleteAsync(WarmingDeleteDataTransfer Model)
        {
            List<Warming> dataSource = await UnitOfWork.Warming.SelectAsync(x => x.Id == Model.Id);
            Warming warming = Mapper.Map<Warming>(dataSource[0]);

            await UnitOfWork.Warming.DeleteAsync(warming);
            int result = await UnitOfWork.SaveChangesAsync();

            return new WarmingServiceResponse
            {
                Success = result
            };
        }

        public async Task<WarmingServiceResponse> SelectAsync(WarmingSelectDataTransfer Model)
        {
            List<Warming> DataSource = await UnitOfWork.Warming.SelectAsync(x => x.IsActive == true);
            return new WarmingServiceResponse { List = DataSource };
        }

        public async Task<WarmingServiceResponse> AnySelectAsync(WarmingAnyDataTransfer Model)
        {
            WarmingServiceResponse response = new WarmingServiceResponse();
            response.IsAvailable = await UnitOfWork.Warming.AnySelectAsync(x => x.Id == Model.Id);
            return response;
        }
    }
}