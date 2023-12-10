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
    }
}