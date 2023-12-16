namespace Blue.Core
{
	public class TypeRegisterDto
	{
		public string Name { get; set; } = String.Empty;
	}

	public class TypeUpdateDto
	{
		public Guid Id { get; set; }
	}

	public class TypeDeleteDto
	{
		public Guid Id { get; set; }
	}

	public class TypeSelectDto
	{
		public Guid Id { get; set; }
	}
}