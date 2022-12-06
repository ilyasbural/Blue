namespace Blue.Core
{
    public partial class District : Base<District>, IEntity
    {
        public Guid? City { get; set; }
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public DateTime? RegisterDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? IsActive { get; set; }

        public virtual City? CityNavigation { get; set; }
        public virtual ICollection<RealEstate> RealEstates { get; } = new List<RealEstate>();
    }
}