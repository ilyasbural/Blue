namespace Blue.Core
{
    public class RealEstate : Base<RealEstate>, IEntity
    {
        public string Name { get; set; } = String.Empty;

        public RealEstate()
        {

        }
    }
}