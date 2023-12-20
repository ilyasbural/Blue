namespace Blue.Core
{
	public class District : Base<District>, IEntity
	{
		//public City City { get; set; } = null!;
		public string Name { get; set; } = String.Empty;

		public District()
		{

		}
	}
}