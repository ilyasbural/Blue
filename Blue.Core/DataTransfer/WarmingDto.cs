namespace Blue.Core
{
    public class WarmingRegisterDto
    {
        public string Name { get; set; } = String.Empty;
    }

    public class WarmingUpdateDto
    {
        public Guid Id { get; set; }
		public string Name { get; set; } = String.Empty;
		public DateTime? RegisterDate { get; set; }
		public DateTime? UpdateDate { get; set; }
	}

    public class WarmingDeleteDto
    {
        public Guid Id { get; set; }
    }

    public class WarmingSelectDto
    {
        public Guid Id { get; set; }
    }
}