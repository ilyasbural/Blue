namespace Blue.Presentation
{
	public class RealEstateComplexModel
	{
		public List<Core.BuildingType> BuildingTypeDataSource { get; set; } = null!;
		public List<Core.BuyingType> BuyingTypeDataSource { get; set; } = null!;
		public List<Core.City> CityDataSource { get; set; } = null!;
		public List<Core.District> DistrictDataSource { get; set; } = null!;
		public List<Core.FeaturesAround> FeaturesAroundDataSource { get; set; } = null!;
		public List<Core.FeaturesInside> FeaturesInsideDataSource { get; set; } = null!;
		public List<Core.FeaturesOutside> FeaturesOutsideDataSource { get; set; } = null!;
		public List<Core.FromWho> FromWhoDataSource { get; set; } = null!;
		public List<Core.FuelType> FuelTypeDataSource { get; set; } = null!;
		public List<Core.Furniture> FurnitureDataSource { get; set; } = null!;
		public List<Core.Hometown> HometownDataSource { get; set; } = null!;
		public List<Core.Price> PriceDataSource { get; set; } = null!;
		public List<Core.Room> RoomDataSource { get; set; } = null!;
		public List<Core.Size> SizeDataSource { get; set; } = null!;
		public List<Core.Status> StatusDataSource { get; set; } = null!;
		public List<Core.Type> TypeDataSource { get; set; } = null!;
		public List<Core.Warming> WarmingDataSource { get; set; } = null!;

		public RealEstateComplexModel() 
		{

		}
	}
}