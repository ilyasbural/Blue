namespace Blue.Core
{
    public class District : Base<District>, IEntity
    {
        public string Name { get; set; } = String.Empty;

        public District()
        {
            
        }
    }
}