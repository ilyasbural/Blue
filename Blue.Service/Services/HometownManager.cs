namespace Blue.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class HometownManager : BusinessObject<Hometown>, IHometownService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Hometown> Validator;

        public HometownManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Hometown> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<Hometown>> InsertAsync(HometownRegisterDto Model)
        {
            Data = Mapper.Map<Hometown>(Model);
            Data.Id = Guid.NewGuid();
            Data.RegisterDate = DateTime.Now;
            Data.UpdateDate = DateTime.Now;
            Data.IsActive = true;

            Validator.ValidateAndThrow<Hometown>(Data);
            await UnitOfWork.Hometown.InsertAsync(Data);
            int Success = await UnitOfWork.SaveChangesAsync();

            return new Response<Hometown>
            {
                Success = Success,
                Data = Data,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<Hometown>> UpdateAsync(HometownUpdateDto Model)
        {
            Collection = await UnitOfWork.Hometown.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            Collection[0].Name = Model.Name;
            Collection[0].UpdateDate = DateTime.Now;
            await UnitOfWork.Hometown.UpdateAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<Hometown>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<Hometown>> DeleteAsync(HometownDeleteDto Model)
        {
            Collection = await UnitOfWork.Hometown.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            await UnitOfWork.Hometown.DeleteAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<Hometown>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<Hometown>> SelectAsync(HometownSelectDto Model)
        {
            Collection = await UnitOfWork.Hometown.SelectAsync(x => x.IsActive == true);
            return new Response<Hometown>
            {
                Success = 1,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<Hometown>> SelectSingleAsync(HometownSelectDto Model)
        {
            Collection = await UnitOfWork.Hometown.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<Hometown>
            {
                Success = 1,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }
    }
}