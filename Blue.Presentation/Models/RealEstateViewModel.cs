namespace Blue.Presentation
{
    public class RealEstateViewModel : BaseViewModel
	{
		public BuildingTypeViewModel BuildingTypeViewModel { get; set; }
		public BuyingTypeViewModel BuyingTypeViewModel { get; set; }
		public CityViewModel CityViewModel { get; set; }
		public DistrictViewModel DistrictViewModel { get; set; }
		public FeaturesAroundViewModel FeaturesAroundViewModel { get; set; }
		public FeaturesInsideViewModel FeaturesInsideViewModel { get; set; }
		public FeaturesOutsideViewModel FeaturesOutsideViewModel { get; set; }
		public FromWhoViewModel FromWhoViewModel { get; set; }
		public FuelTypeViewModel FuelTypeViewModel { get; set; }
		public FurnitureViewModel FurnitureViewModel { get; set; }
		public HometownViewModel HometownViewModel { get; set; }
		public PriceViewModel PriceViewModel { get; set; }
		public RoomViewModel RoomViewModel { get; set; }
		public SizeViewModel SizeViewModel { get; set; }
		public StatusViewModel StatusViewModel { get; set; }
		public TypeViewModel TypeViewModel { get; set; }
		public WarmingViewModel WarmingViewModel { get; set; }
		public string Name { get; set; } = String.Empty;

        public RealEstateViewModel()
        {
			BuildingTypeViewModel = new BuildingTypeViewModel();
            BuyingTypeViewModel = new BuyingTypeViewModel();
			CityViewModel = new CityViewModel();	
			DistrictViewModel = new DistrictViewModel();
            FeaturesAroundViewModel = new FeaturesAroundViewModel();
			FeaturesInsideViewModel = new FeaturesInsideViewModel();
			FeaturesOutsideViewModel = new FeaturesOutsideViewModel();
			FromWhoViewModel = new FromWhoViewModel();
			FuelTypeViewModel = new FuelTypeViewModel();
			FurnitureViewModel = new FurnitureViewModel();
			HometownViewModel = new HometownViewModel();
			PriceViewModel = new PriceViewModel();
			RoomViewModel = new RoomViewModel();
			SizeViewModel = new SizeViewModel();
			StatusViewModel = new StatusViewModel();
			TypeViewModel = new TypeViewModel();
			WarmingViewModel = new WarmingViewModel();
        }
    }
}