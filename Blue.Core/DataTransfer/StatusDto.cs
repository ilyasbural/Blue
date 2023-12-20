namespace Blue.Core
{
	public class StatusRegisterDto
	{
		public string Name { get; set; } = String.Empty;
	}

	public class StatusUpdateDto
	{
		public Guid Id { get; set; }
	}

	public class StatusDeleteDto
	{
		public Guid Id { get; set; }
	}

	public class StatusSelectDto
	{
		public Guid Id { get; set; }
	}
}