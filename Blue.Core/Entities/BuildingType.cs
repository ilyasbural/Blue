namespace Blue.Core
{
	public class BuildingType : Base<BuildingType>, IEntity
	{
		public string Name { get; set; } = String.Empty;

		public BuildingType()
		{

		}
	}
}