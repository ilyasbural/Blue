namespace Blue.Core
{
    public partial class Management : Base<Management>, IEntity
    {
        public Guid Id { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime? RegisterDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public bool? IsActive { get; set; }
    }
}