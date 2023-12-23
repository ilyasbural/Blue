namespace Blue.Core
{
    public class RealEstateRegisterDto
    {
        public Guid BuildingType { get; set; }
        public Guid BuyingType { get; set; }
        public Guid City { get; set; }
        public Guid District { get; set; }
        public Guid FeaturesAround { get; set; }
        public Guid FeaturesInside { get; set; }
        public Guid FeaturesOutside { get; set; }
        public Guid FromWho { get; set; }
        public Guid FuelType { get; set; }
        public Guid Furniture { get; set; }
        public Guid Hometown { get; set; }
        public Guid Price { get; set; }
        public Guid Room { get; set; }
        public Guid Size { get; set; }
        public Guid Status { get; set; }
        public Guid Type { get; set; }
        public Guid Warming { get; set; }
        public string Name { get; set; } = String.Empty;
    }

    public class RealEstateUpdateDto
    {
		public Guid BuildingType { get; set; }
		public Guid BuyingType { get; set; }
		public Guid City { get; set; }
		public Guid District { get; set; }
		public Guid FeaturesAround { get; set; }
		public Guid FeaturesInside { get; set; }
		public Guid FeaturesOutside { get; set; }
		public Guid FromWho { get; set; }
		public Guid FuelType { get; set; }
		public Guid Furniture { get; set; }
		public Guid Hometown { get; set; }
		public Guid Price { get; set; }
		public Guid Room { get; set; }
		public Guid Size { get; set; }
		public Guid Status { get; set; }
		public Guid Type { get; set; }
		public Guid Warming { get; set; }
		public Guid Id { get; set; }
		public string Name { get; set; } = String.Empty;
		public DateTime? RegisterDate { get; set; }
		public DateTime? UpdateDate { get; set; }
	}

    public class RealEstateDeleteDto
    {
        public Guid Id { get; set; }
    }

    public class RealEstateSelectDto
    {
        public Guid Id { get; set; }
    }
}