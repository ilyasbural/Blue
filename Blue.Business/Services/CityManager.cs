namespace Blue.Business
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class CityManager : BusinessObjectBase<City>, ICityService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<City> Validator;

        public CityManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<City> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<City>> InsertAsync(CityInsertDataTransfer Model)
        {
            Entity = Mapper.Map<City>(Model);
            Entity.Id = Guid.NewGuid();
            Entity.RegisterDate = DateTime.Now;
            Entity.UpdateDate = DateTime.Now;
            Entity.IsActive = true;
            Validator.ValidateAndThrow<City>(Entity);
            await UnitOfWork.City.InsertAsync(Entity);
            Result = await UnitOfWork.SaveChangesAsync();

            return new Response<City>
            {
                Message = "Success",
                Data = Entity, 
                Success = Result, 
                IsValidationError = false
            };
        }

        public async Task<Response<City>> UpdateAsync(CityUpdateDataTransfer Model)
        {
            Collection = await UnitOfWork.City.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<City>(Collection[0]);
            Entity.UpdateDate = DateTime.Now;
            Validator.ValidateAndThrow<City>(Entity);
            await UnitOfWork.City.UpdateAsync(Entity);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<City>
            {
                Message = "Success",
                Data = Entity,
                Success = Result,
                IsValidationError = false
            };
        }

        public async Task<Response<City>> DeleteAsync(CityDeleteDataTransfer Model)
        {
            Collection = await UnitOfWork.City.SelectAsync(x => x.Id == Model.Id);
            Entity = Mapper.Map<City>(Collection[0]);
            await UnitOfWork.City.DeleteAsync(Entity);
            int result = await UnitOfWork.SaveChangesAsync();

            return new Response<City>
            {
                Message = "Success",
                Data = Entity,
                Success = Result,
                IsValidationError = false
            };
        }

        public async Task<Response<City>> SelectAsync(CitySelectDataTransfer Model)
        {
            Collection = await UnitOfWork.City.SelectAsync(x => x.IsActive == true);
            return new Response<City>
            {
                Message = "Success",
                Collection = Collection,
                Success = Result,
                IsValidationError = false
            };
        }

        public async Task<Response<City>> AnySelectAsync(CityAnyDataTransfer Model)
        {
            Collection = await UnitOfWork.City.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<City>
            {
                Message = "Success",
                Collection = Collection,
                Success = Result,
                IsValidationError = false
            };
        }
    }
}