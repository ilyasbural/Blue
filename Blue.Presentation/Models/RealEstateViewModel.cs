namespace Blue.Presentation
{
    public class RealEstateViewModel : BaseViewModel
	{
		public BuildingTypeViewModel BuildingTypeViewModel { get; set; } = null!;
		public BuyingTypeViewModel BuyingTypeViewModel { get; set; } = null!;
		public CityViewModel CityViewModel { get; set; } = null!;
		public DistrictViewModel DistrictViewModel { get; set; } = null!;
		public FeaturesAroundViewModel FeaturesAroundViewModel { get; set; } = null!;
		public FeaturesInsideViewModel FeaturesInsideViewModel { get; set; } = null!;
		public FeaturesOutsideViewModel FeaturesOutsideViewModel { get; set; } = null!;
		public FromWhoViewModel FromWhoViewModel { get; set; } = null!;
		public FuelTypeViewModel FuelTypeViewModel { get; set; } = null!;
		public FurnitureViewModel FurnitureViewModel { get; set; } = null!;
		public HometownViewModel HometownViewModel { get; set; } = null!;
		public PriceViewModel PriceViewModel { get; set; } = null!;
		public RoomViewModel RoomViewModel { get; set; } = null!;
		public SizeViewModel SizeViewModel { get; set; } = null!;
		public StatusViewModel StatusViewModel { get; set; } = null!;
		public TypeViewModel TypeViewModel { get; set; } = null!;
		public WarmingViewModel WarmingViewModel { get; set; } = null!;

		public string Name { get; set; } = String.Empty;
	}
}