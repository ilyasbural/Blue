namespace Blue.Core
{
	public class SizeRegisterDto
	{
		public string Name { get; set; } = String.Empty;
	}

	public class SizeUpdateDto
	{
		public Guid Id { get; set; }
	}

	public class SizeDeleteDto
	{
		public Guid Id { get; set; }
	}

	public class SizeSelectDto
	{
		public Guid Id { get; set; }
	}
}