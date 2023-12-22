namespace Blue.Core
{
    public class HometownRegisterDto
    {
        public string Name { get; set; } = String.Empty;
    }

    public class HometownUpdateDto
    {
        public Guid Id { get; set; }
		public string Name { get; set; } = String.Empty;
		public DateTime? RegisterDate { get; set; }
		public DateTime? UpdateDate { get; set; }
	}

    public class HometownDeleteDto
    {
        public Guid Id { get; set; }
    }

    public class HometownSelectDto
    {
        public Guid Id { get; set; }
    }
}