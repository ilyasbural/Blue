namespace Blue.Core
{
    public partial class RealEstateDetail : Base<RealEstateDetail>, IEntity
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public DateTime? RegisterDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? IsActive { get; set; }

        public virtual RealEstate IdNavigation { get; set; } = null!;
    }
}