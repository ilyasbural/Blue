namespace Blue.Core
{
    public class City : Base<City>, IEntity
    {
        public string Name { get; set; } = String.Empty;

        public City()
        {
            
        }
    }
}