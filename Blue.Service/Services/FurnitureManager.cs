namespace Blue.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class FurnitureManager : BusinessObject<Furniture>, IFurnitureService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Furniture> Validator;

        public FurnitureManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Furniture> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<Furniture>> InsertAsync(FurnitureRegisterDto Model)
        {
            Data = Mapper.Map<Furniture>(Model);
            Data.Id = Guid.NewGuid();
            Data.RegisterDate = DateTime.Now;
            Data.UpdateDate = DateTime.Now;
            Data.IsActive = true;

            Validator.ValidateAndThrow<Furniture>(Data);
            await UnitOfWork.Furniture.InsertAsync(Data);
            int Success = await UnitOfWork.SaveChangesAsync();

            return new Response<Furniture>
            {
                Success = 1,
                Data = Data,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<Furniture>> UpdateAsync(FurnitureUpdateDto Model)
        {
            Collection = await UnitOfWork.Furniture.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            Collection[0].Name = Model.Name;
            Collection[0].UpdateDate = DateTime.Now;
            await UnitOfWork.Furniture.UpdateAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<Furniture>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<Furniture>> DeleteAsync(FurnitureDeleteDto Model)
        {
            Collection = await UnitOfWork.Furniture.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            await UnitOfWork.Furniture.DeleteAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<Furniture>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<Furniture>> SelectAsync(FurnitureSelectDto Model)
        {
            Collection = await UnitOfWork.Furniture.SelectAsync(x => x.IsActive == true);
            return new Response<Furniture>
            {
                Success = 1,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<Furniture>> SelectSingleAsync(FurnitureSelectDto Model)
        {
            Collection = await UnitOfWork.Furniture.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<Furniture>
            {
                Success = 1,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }
    }
}