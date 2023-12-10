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
    }
}