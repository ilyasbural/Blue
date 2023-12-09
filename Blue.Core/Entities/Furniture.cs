namespace Blue.Core
{
    public class Furniture : Base<Furniture>, IEntity
    {
        public string Name { get; set; } = String.Empty;

        public Furniture()
        {
            
        }
    }
}