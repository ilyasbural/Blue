namespace Blue.Core
{
    public class FromWhoRegisterDto
    {
        public string Name { get; set; } = String.Empty;
    }

    public class FromWhoUpdateDto
    {
        public Guid Id { get; set; }
		public string Name { get; set; } = String.Empty;
		public DateTime? RegisterDate { get; set; }
		public DateTime? UpdateDate { get; set; }
	}

    public class FromWhoDeleteDto
    {
        public Guid Id { get; set; }
    }

    public class FromWhoSelectDto
    {
        public Guid Id { get; set; }
    }
}