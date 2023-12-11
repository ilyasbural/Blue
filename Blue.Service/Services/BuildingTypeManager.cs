namespace Blue.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class BuildingTypeManager : BusinessObject<BuildingType>, IBuildingTypeService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<BuildingType> Validator;

        public BuildingTypeManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<BuildingType> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<BuildingType>> InsertAsync(BuildingTypeRegisterDto Model)
        {
            Data = Mapper.Map<BuildingType>(Model);
            Data.Id = Guid.NewGuid();
            Data.RegisterDate = DateTime.Now;
            Data.UpdateDate = DateTime.Now;
            Data.IsActive = true;

            Validator.ValidateAndThrow<BuildingType>(Data);
            await UnitOfWork.BuildingType.InsertAsync(Data);
            int Success = await UnitOfWork.SaveChangesAsync();

            return new Response<BuildingType>
            {
                Success = Success,
                Data = Data,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<BuildingType>> UpdateAsync(BuildingTypeUpdateDto Model)
        {
            Collection = await UnitOfWork.BuildingType.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            await UnitOfWork.BuildingType.UpdateAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<BuildingType>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }
    }
}