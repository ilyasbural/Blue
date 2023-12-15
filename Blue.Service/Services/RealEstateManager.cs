namespace Blue.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class RealEstateManager : BusinessObject<RealEstate>, IRealEstateService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<RealEstate> Validator;

        public RealEstateManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<RealEstate> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<RealEstate>> InsertAsync(RealEstateRegisterDto Model)
        {
            Data = Mapper.Map<RealEstate>(Model);
            Data.Id = Guid.NewGuid();
            Data.RegisterDate = DateTime.Now;
            Data.UpdateDate = DateTime.Now;
            Data.IsActive = true;

            RealEstateDetail Detail = new RealEstateDetail();
            Detail.Id = Data.Id;
            Detail.RegisterDate = DateTime.Now;
            Detail.UpdateDate = DateTime.Now;
            Detail.IsActive = true;

            Validator.ValidateAndThrow<RealEstate>(Data);
            await UnitOfWork.RealEstate.InsertAsync(Data);
            await UnitOfWork.RealEstateDetail.InsertAsync(Detail);
            int Success = await UnitOfWork.SaveChangesAsync();

            return new Response<RealEstate>
            {
                Data = Data,
                Success = Success,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<RealEstate>> UpdateAsync(RealEstateUpdateDto Model)
        {
            Collection = await UnitOfWork.RealEstate.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            await UnitOfWork.RealEstate.UpdateAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<RealEstate>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<RealEstate>> DeleteAsync(RealEstateDeleteDto Model)
        {
            Collection = await UnitOfWork.RealEstate.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            await UnitOfWork.RealEstate.DeleteAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<RealEstate>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<RealEstate>> SelectAsync(RealEstateSelectDto Model)
        {
            Collection = await UnitOfWork.RealEstate.SelectAsync(x => x.IsActive == true);
            return new Response<RealEstate>
            {
                Success = 1,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<RealEstate>> SelectSingleAsync(RealEstateSelectDto Model)
        {
            Collection = await UnitOfWork.RealEstate.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<RealEstate>
            {
                Success = 1,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }
    }
}