namespace Blue.Service
{
    using Core;
    using AutoMapper;
    using FluentValidation;

    public class CityManager : BusinessObject<City>, ICityService
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

        public async Task<Response<City>> InsertAsync(CityRegisterDto Model)
        {
            Data = Mapper.Map<City>(Model);
            Data.Id = Guid.NewGuid();
            Data.RegisterDate = DateTime.Now;
            Data.UpdateDate = DateTime.Now;
            Data.IsActive = true;

            Validator.ValidateAndThrow<City>(Data);
            await UnitOfWork.City.InsertAsync(Data);
            int Success = await UnitOfWork.SaveChangesAsync();

            return new Response<City>
            {
                Success = Success,
                Data = Data,
                Message = "Success",
                IsValidationError = false
            };
        }

        public async Task<Response<City>> UpdateAsync(CityUpdateDto Model)
        {
            Collection = await UnitOfWork.City.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			Collection[0].Name = Model.Name;
			Collection[0].UpdateDate = DateTime.Now;
			await UnitOfWork.City.UpdateAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<City>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<City>> DeleteAsync(CityDeleteDto Model)
        {
            Collection = await UnitOfWork.City.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			await UnitOfWork.City.DeleteAsync(Collection[0]);
            Success = await UnitOfWork.SaveChangesAsync();

            return new Response<City>
            {
                Success = Success,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<City>> SelectAsync(CitySelectDto Model)
        {
            Collection = await UnitOfWork.City.SelectAsync(x => x.IsActive == true);
            return new Response<City>
            {
                Success = 1,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }

        public async Task<Response<City>> SelectSingleAsync(CitySelectDto Model)
        {
            Collection = await UnitOfWork.City.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<City>
            {
                Success = 1,
                Message = "Success",
                Collection = Collection,
                IsValidationError = false
            };
        }
    }
}