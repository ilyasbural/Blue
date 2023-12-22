namespace Blue.Core
{
    public class Management : Base<Management>, IEntity
    {
        public string Name { get; set; } = String.Empty;

        public Management()
        {

        }
    }
}