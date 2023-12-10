namespace Blue.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class RoomManager : BusinessObject<Room>, IRoomService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Room> Validator;

        public RoomManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Room> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<Room>> InsertAsync(RoomRegisterDto Model)
        {
            Data = Mapper.Map<Room>(Model);
            Data.Id = Guid.NewGuid();
            Data.RegisterDate = DateTime.Now;
            Data.UpdateDate = DateTime.Now;
            Data.IsActive = true;

            Validator.ValidateAndThrow<Room>(Data);
            await UnitOfWork.Room.InsertAsync(Data);
            int Success = await UnitOfWork.SaveChangesAsync();

            return new Response<Room>
            {
                Success = Success,
                Data = Data,
                Message = "Success",
                IsValidationError = false
            };
        }
    }
}