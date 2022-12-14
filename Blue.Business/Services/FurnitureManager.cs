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

        public async Task<FurnitureServiceResponse> InsertAsync(FurnitureInsertDataTransfer Model)
        {
            Furniture furniture = Mapper.Map<Furniture>(Model);
            furniture.Id = Guid.NewGuid();
            furniture.RegisterDate = DateTime.Now;
            furniture.UpdateDate = DateTime.Now;
            furniture.IsActive = true;

            await UnitOfWork.Furniture.InsertAsync(furniture);
            int result = await UnitOfWork.SaveChangesAsync();

            return new FurnitureServiceResponse 
            { 
                Single = furniture, 
                Success = result 
            };
        }

        public async Task<FurnitureServiceResponse> UpdateAsync(FurnitureUpdateDataTransfer Model)
        {
            List<Furniture> DataSource = await UnitOfWork.Furniture.SelectAsync(x => x.Id == Model.Id);
            Furniture furniture = Mapper.Map<Furniture>(DataSource[0]);
            furniture.UpdateDate = DateTime.Now;

            await UnitOfWork.Furniture.UpdateAsync(furniture);
            int result = await UnitOfWork.SaveChangesAsync();

            return new FurnitureServiceResponse
            {
                Single = furniture,
                Success = result
            };
        }

        public async Task<FurnitureServiceResponse> DeleteAsync(FurnitureDeleteDataTransfer Model)
        {
            List<Furniture> dataSource = await UnitOfWork.Furniture.SelectAsync(x => x.Id == Model.Id);
            Furniture furniture = Mapper.Map<Furniture>(dataSource[0]);

            await UnitOfWork.Furniture.DeleteAsync(furniture);
            int result = await UnitOfWork.SaveChangesAsync();

            return new FurnitureServiceResponse
            {
                Success = result
            };
        }

        public async Task<FurnitureServiceResponse> SelectAsync(FurnitureSelectDataTransfer Model)
        {
            List<Furniture> DataSource = await UnitOfWork.Furniture.SelectAsync(x => x.IsActive == true);
            return new FurnitureServiceResponse { List = DataSource };
        }

        public async Task<FurnitureServiceResponse> AnySelectAsync(FurnitureAnyDataTransfer Model)
        {
            FurnitureServiceResponse response = new FurnitureServiceResponse();
            response.IsAvailable = await UnitOfWork.Furniture.AnySelectAsync(x => x.Id == Model.Id);
            return response;
        }
    }
}