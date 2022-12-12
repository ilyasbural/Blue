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
            await UnitOfWork.SaveChangesAsync();

            return new FurnitureServiceResponse { Furniture = furniture };
        }

        public async Task<FurnitureServiceResponse> UpdateAsync(FurnitureUpdateDataTransfer Model)
        {
            List<Furniture> DataSource = await UnitOfWork.Furniture.SelectAsync(x => x.Id == Model.Id);
            Furniture furniture = Mapper.Map<Furniture>(DataSource[0]);
            furniture.UpdateDate = DateTime.Now;

            await UnitOfWork.Furniture.UpdateAsync(furniture);
            await UnitOfWork.SaveChangesAsync();

            FurnitureServiceResponse furnitureServiceResponse = Mapper.Map<FurnitureServiceResponse>(furniture);
            return new FurnitureServiceResponse { };
        }

        public async Task<FurnitureServiceResponse> DeleteAsync(FurnitureDeleteDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<FurnitureServiceResponse> SelectAsync(FurnitureSelectDataTransfer Model)
        {
            throw new NotImplementedException();
        }

        public async Task<FurnitureServiceResponse> AnySelectAsync(FurnitureAnyDataTransfer Model)
        {
            throw new NotImplementedException();
        }
    }
}