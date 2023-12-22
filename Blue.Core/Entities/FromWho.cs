namespace Blue.Core
{
    public class FromWho : Base<FromWho>, IEntity
    {
        public string Name { get; set; } = String.Empty;

        public FromWho()
        {

        }
    }
}