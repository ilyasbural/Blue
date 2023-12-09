namespace Blue.Core
{
    public class Price : Base<Price>, IEntity
    {
        public string Name { get; set; } = String.Empty;

        public Price()
        {
            
        }
    }
}