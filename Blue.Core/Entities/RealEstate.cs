namespace Blue.Core
{
    public partial class RealEstate : Base<RealEstate>, IEntity
    {
        public Guid? City { get; set; }
        public Guid? District { get; set; }
        public Guid? Furniture { get; set; }
        public Guid? Price { get; set; }
        public Guid? Size { get; set; }
        public Guid? Type { get; set; }
        public Guid? Warming { get; set; }
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public DateTime? RegisterDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? IsActive { get; set; }

        public virtual City? CityNavigation { get; set; }
        public virtual District? DistrictNavigation { get; set; }
        public virtual Furniture? FurnitureNavigation { get; set; }
        public virtual Price? PriceNavigation { get; set; }
        public virtual RealEstateDetail? RealEstateDetail { get; set; }
        public virtual Size? SizeNavigation { get; set; }
        public virtual Type? TypeNavigation { get; set; }
        public virtual Warming? WarmingNavigation { get; set; }
    }
}