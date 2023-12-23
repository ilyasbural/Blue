namespace Blue.Core
{
    public class RealEstate : Base<RealEstate>, IEntity
    {
        public BuildingType BuildingType { get; set; } = null!;
        public BuyingType BuyingType { get; set; } = null!;
        public City City { get; set; } = null!;
        public District District { get; set; } = null!;
        public FeaturesAround FeaturesAround { get; set; } = null!;
        public FeaturesInside FeaturesInside { get; set; } = null!;
        public FeaturesOutside FeaturesOutside { get; set; } = null!;
        public FromWho FromWho { get; set; } = null!;
        public FuelType FuelType { get; set; } = null!;
        public Furniture Furniture { get; set; } = null!;
        public Hometown Hometown { get; set; } = null!;
        public Price Price { get; set; } = null!;
        public Room Room { get; set; } = null!;
        public Size Size { get; set; } = null!;
        public Status Status { get; set; } = null!;
        public Type Type { get; set; } = null!;
        public Warming Warming { get; set; } = null!;
        public string Name { get; set; } = String.Empty;

        public RealEstate()
        {

        }
    }
}