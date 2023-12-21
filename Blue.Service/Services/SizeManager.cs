namespace Blue.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class SizeManager : BusinessObject<Size>, ISizeService
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

        public async Task<Response<Size>> InsertAsync(SizeRegisterDto Model)
        {
            Data = Mapper.Map<Size>(Model);
            Data.Id = Guid.NewGuid();
            Data.RegisterDate = DateTime.Now;
            Data.UpdateDate = DateTime.Now;
            Data.IsActive = true;

            Validator.ValidateAndThrow<Size>(Data);
            await UnitOfWork.Size.InsertAsync(Data);
            int Success = await UnitOfWork.SaveChangesAsync();

            return new Response<Size>
            {
                Success = Success,
                Data = Data,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<Size>> UpdateAsync(SizeUpdateDto Model)
        {
            Collection = await UnitOfWork.Size.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            await UnitOfWork.Size.UpdateAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<Size>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<Size>> DeleteAsync(SizeDeleteDto Model)
        {
            Collection = await UnitOfWork.Size.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            await UnitOfWork.Size.DeleteAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<Size>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<Size>> SelectAsync(SizeSelectDto Model)
        {
            Collection = await UnitOfWork.Size.SelectAsync(x => x.IsActive == true);
            return new Response<Size>
            {
                Success = 1,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<Size>> SelectSingleAsync(SizeSelectDto Model)
        {
            Collection = await UnitOfWork.Size.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<Size>
            {
                Success = 1,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }
    }
}