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
            List<BuildingType> BuildingType = await UnitOfWork.BuildingType.SelectAsync(x => x.Id == Model.BuildingType);
            List<BuyingType> BuyingType = await UnitOfWork.BuyingType.SelectAsync(x => x.Id == Model.BuyingType);
            List<City> City = await UnitOfWork.City.SelectAsync(x => x.Id == Model.City);
            List<District> District = await UnitOfWork.District.SelectAsync(x => x.Id == Model.District);
            List<FeaturesAround> FeaturesAround = await UnitOfWork.FeaturesAround.SelectAsync(x => x.Id == Model.FeaturesAround);
            List<FeaturesInside> FeaturesInside = await UnitOfWork.FeaturesInside.SelectAsync(x => x.Id == Model.FeaturesInside);
            List<FeaturesOutside> FeaturesOutside = await UnitOfWork.FeaturesOutside.SelectAsync(x => x.Id == Model.FeaturesOutside);
            List<FromWho> FromWho = await UnitOfWork.FromWho.SelectAsync(x => x.Id == Model.FromWho);
            List<FuelType> FuelType = await UnitOfWork.FuelType.SelectAsync(x => x.Id == Model.FuelType);
            List<Furniture> Furniture = await UnitOfWork.Furniture.SelectAsync(x => x.Id == Model.Furniture);
            List<Hometown> Hometown = await UnitOfWork.Hometown.SelectAsync(x => x.Id == Model.Hometown);
            List<Price> Price = await UnitOfWork.Price.SelectAsync(x => x.Id == Model.Price);
            List<Room> Room = await UnitOfWork.Room.SelectAsync(x => x.Id == Model.Room);
            List<Size> Size = await UnitOfWork.Size.SelectAsync(x => x.Id == Model.Size);
            List<Status> Status = await UnitOfWork.Status.SelectAsync(x => x.Id == Model.Status);
            List<Type> Type = await UnitOfWork.Type.SelectAsync(x => x.Id == Model.Type);
            List<Warming> Warming = await UnitOfWork.Warming.SelectAsync(x => x.Id == Model.Warming);

            Data = new RealEstate();
            Data.BuildingType = new BuildingType();
            Data.BuyingType = new BuyingType();
            Data.City = new City();
            Data.District = new District();
            Data.FeaturesAround = new FeaturesAround();
            Data.FeaturesInside = new FeaturesInside();
            Data.FeaturesOutside = new FeaturesOutside();
            Data.FromWho = new FromWho();
            Data.FuelType = new FuelType();
            Data.Furniture = new Furniture();
            Data.Hometown = new Hometown();
            Data.Price = new Price();
            Data.Room = new Room();
            Data.Size = new Size();
            Data.Status = new Status();
            Data.Type = new Type();
            Data.Warming = new Warming();

            Data.BuildingType = BuildingType.First();
            Data.BuyingType = BuyingType.First();
            Data.City = City.First();
            Data.District = District.First();
            Data.FeaturesAround = FeaturesAround.First();
            Data.FeaturesInside = FeaturesInside.First();
            Data.FeaturesOutside = FeaturesOutside.First();
            Data.FromWho = FromWho.First();
            Data.FuelType = FuelType.First();
            Data.Furniture = Furniture.First();
            Data.Hometown = Hometown.First();
            Data.Price = Price.First();
            Data.Room = Room.First();
            Data.Size = Size.First();
            Data.Status = Status.First();
            Data.Type = Type.First();
            Data.Warming = Warming.First();
            Data.Id = Guid.NewGuid();
            Data.Name = Model.Name;
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
            List<BuildingType> BuildingType = await UnitOfWork.BuildingType.SelectAsync(x => x.Id == Model.BuildingType);
            List<BuyingType> BuyingType = await UnitOfWork.BuyingType.SelectAsync(x => x.Id == Model.BuyingType);
            List<City> City = await UnitOfWork.City.SelectAsync(x => x.Id == Model.City);
            List<District> District = await UnitOfWork.District.SelectAsync(x => x.Id == Model.District);
            List<FeaturesAround> FeaturesAround = await UnitOfWork.FeaturesAround.SelectAsync(x => x.Id == Model.FeaturesAround);
            List<FeaturesInside> FeaturesInside = await UnitOfWork.FeaturesInside.SelectAsync(x => x.Id == Model.FeaturesInside);
            List<FeaturesOutside> FeaturesOutside = await UnitOfWork.FeaturesOutside.SelectAsync(x => x.Id == Model.FeaturesOutside);
            List<FromWho> FromWho = await UnitOfWork.FromWho.SelectAsync(x => x.Id == Model.FromWho);
            List<FuelType> FuelType = await UnitOfWork.FuelType.SelectAsync(x => x.Id == Model.FuelType);
            List<Furniture> Furniture = await UnitOfWork.Furniture.SelectAsync(x => x.Id == Model.Furniture);
            List<Hometown> Hometown = await UnitOfWork.Hometown.SelectAsync(x => x.Id == Model.Hometown);
            List<Price> Price = await UnitOfWork.Price.SelectAsync(x => x.Id == Model.Price);
            List<Room> Room = await UnitOfWork.Room.SelectAsync(x => x.Id == Model.Room);
            List<Size> Size = await UnitOfWork.Size.SelectAsync(x => x.Id == Model.Size);
            List<Status> Status = await UnitOfWork.Status.SelectAsync(x => x.Id == Model.Status);
            List<Type> Type = await UnitOfWork.Type.SelectAsync(x => x.Id == Model.Type);
            List<Warming> Warming = await UnitOfWork.Warming.SelectAsync(x => x.Id == Model.Warming);

            Collection = await UnitOfWork.RealEstate.SelectAsync(x => x.Id == Model.Id, x => x.BuildingType);
            Collection[0].BuildingType = BuildingType.First();
            Collection[0].BuyingType = BuyingType.First();
            Collection[0].City = City.First();
            Collection[0].District = District.First();
            Collection[0].FeaturesAround = FeaturesAround.First();
            Collection[0].FeaturesInside = FeaturesInside.First();
            Collection[0].FeaturesOutside = FeaturesOutside.First();
            Collection[0].FromWho = FromWho.First();
            Collection[0].FuelType = FuelType.First();
            Collection[0].Furniture = Furniture.First();
            Collection[0].Hometown = Hometown.First();
            Collection[0].Name = Model.Name;
            Collection[0].UpdateDate = DateTime.Now;

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
            Collection = await UnitOfWork.RealEstate.SelectAsync(x => x.Id == Model.Id && x.IsActive == true, 
            x => x.BuildingType, x => x.BuyingType, x => x.City, x => x.District, x => x.FeaturesAround, x => x.FeaturesInside, 
            x => x.FeaturesOutside, x => x.FromWho, x => x.FuelType, x => x.Furniture, x => x.Hometown);
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