namespace Blue.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;
    using System.Threading.Tasks;
    using System.Collections.Generic;

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

        public async Task<PriceServiceResponse> InsertAsync(PriceInsertDataTransfer Model)
        {
            Price price = Mapper.Map<Price>(Model);
            price.Id = Guid.NewGuid();
            price.RegisterDate = DateTime.Now;
            price.UpdateDate = DateTime.Now;
            price.IsActive = true;

            await UnitOfWork.Price.InsertAsync(price);
            int result = await UnitOfWork.SaveChangesAsync();

            return new PriceServiceResponse 
            { 
                Single = price, 
                Success = result 
            };
        }

        public async Task<PriceServiceResponse> UpdateAsync(PriceUpdateDataTransfer Model)
        {
            List<Price> DataSource = await UnitOfWork.Price.SelectAsync(x => x.Id == Model.Id);
            Price price = Mapper.Map<Price>(DataSource[0]);
            price.UpdateDate = DateTime.Now;

            await UnitOfWork.Price.UpdateAsync(price);
            int result = await UnitOfWork.SaveChangesAsync();

            return new PriceServiceResponse
            {
                Single = price,
                Success = result
            };
        }

        public async Task<PriceServiceResponse> DeleteAsync(PriceDeleteDataTransfer Model)
        {
            List<Price> dataSource = await UnitOfWork.Price.SelectAsync(x => x.Id == Model.Id);
            Price price = Mapper.Map<Price>(dataSource[0]);

            await UnitOfWork.Price.DeleteAsync(price);
            int result = await UnitOfWork.SaveChangesAsync();

            return new PriceServiceResponse
            {
                Success = result
            };
        }

        public async Task<PriceServiceResponse> SelectAsync(PriceSelectDataTransfer Model)
        {
            List<Price> DataSource = await UnitOfWork.Price.SelectAsync(x => x.IsActive == true);
            return new PriceServiceResponse { List = DataSource };
        }

        public async Task<PriceServiceResponse> AnySelectAsync(PriceAnyDataTransfer Model)
        {
            PriceServiceResponse response = new PriceServiceResponse();
            response.IsAvailable = await UnitOfWork.Price.AnySelectAsync(x => x.Id == Model.Id);
            return response;
        }
    }
}