namespace Blue.Core
{
    public partial class Picture : Base<Picture>, IEntity
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public DateTime? RegisterDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? IsActive { get; set; }
    }
}