namespace Blue.Core
{
    public class Type : Base<Type>, IEntity
    {
        public string Name { get; set; } = String.Empty;

        public Type()
        {
            
        }
    }
}