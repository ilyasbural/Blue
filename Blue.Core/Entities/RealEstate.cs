namespace Blue.Core
{
    public partial class RealEstate
    {
        public Guid? RealEstateType { get; set; }
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public DateTime? RegisterDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? IsActive { get; set; }

        public virtual Type? RealEstateTypeNavigation { get; set; }
    }
}