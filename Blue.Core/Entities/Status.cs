namespace Blue.Core
{
    public class Status : Base<Status>, IEntity
    {
        public string Name { get; set; } = String.Empty;

        public Status()
        {

        }
    }
}