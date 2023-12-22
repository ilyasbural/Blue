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

        public async Task<Response<Room>> UpdateAsync(RoomUpdateDto Model)
        {
            Collection = await UnitOfWork.Room.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			Collection[0].Name = Model.Name;
			Collection[0].UpdateDate = DateTime.Now;
			await UnitOfWork.Room.UpdateAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<Room>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<Room>> DeleteAsync(RoomDeleteDto Model)
        {
            Collection = await UnitOfWork.Room.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            await UnitOfWork.Room.DeleteAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<Room>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<Room>> SelectAsync(RoomSelectDto Model)
        {
            Collection = await UnitOfWork.Room.SelectAsync(x => x.IsActive == true);
            return new Response<Room>
            {
                Success = 1,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<Room>> SelectSingleAsync(RoomSelectDto Model)
        {
            Collection = await UnitOfWork.Room.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<Room>
            {
                Success = 1,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }
    }
}