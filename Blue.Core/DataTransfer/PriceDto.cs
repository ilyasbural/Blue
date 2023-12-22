namespace Blue.Core
{
    public class PriceRegisterDto
    {
        public string Name { get; set; } = String.Empty;
    }

    public class PriceUpdateDto
    {
        public Guid Id { get; set; }
		public string Name { get; set; } = String.Empty;
		public DateTime? RegisterDate { get; set; }
		public DateTime? UpdateDate { get; set; }
	}

    public class PriceDeleteDto
    {
        public Guid Id { get; set; }
    }

    public class PriceSelectDto
    {
        public Guid Id { get; set; }
    }
}