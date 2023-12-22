namespace Blue.Core
{
    public class RealEstateRegisterDto
    {
        public string Name { get; set; } = String.Empty;
    }

    public class RealEstateUpdateDto
    {
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