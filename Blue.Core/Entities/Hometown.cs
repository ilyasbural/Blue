namespace Blue.Core
{
    public class Hometown : Base<Hometown>, IEntity
    {
        public string Name { get; set; } = String.Empty;

        public Hometown()
        {

        }
    }
}