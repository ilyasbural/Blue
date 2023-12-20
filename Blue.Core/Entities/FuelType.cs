namespace Blue.Core
{
	public class FuelType : Base<FuelType>, IEntity
	{
		public string Name { get; set; } = String.Empty;

		public FuelType()
		{

		}
	}
}