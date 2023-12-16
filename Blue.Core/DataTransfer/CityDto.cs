namespace Blue.Core
{
	public class CityRegisterDto
	{
		public string Name { get; set; } = String.Empty;
	}

	public class CityUpdateDto
	{
		public Guid Id { get; set; }
	}

	public class CityDeleteDto
	{
		public Guid Id { get; set; }
	}

	public class CitySelectDto
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;
	}
}