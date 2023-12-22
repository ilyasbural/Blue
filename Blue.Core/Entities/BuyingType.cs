namespace Blue.Core
{
    public class BuyingType : Base<BuyingType>, IEntity
    {
        public string Name { get; set; } = String.Empty;

        public BuyingType()
        {

        }
    }
}