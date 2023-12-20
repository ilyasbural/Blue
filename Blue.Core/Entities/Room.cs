namespace Blue.Core
{
	public class Room : Base<Room>, IEntity
	{
		public string Name { get; set; } = String.Empty;

		public Room()
		{

		}
	}
}