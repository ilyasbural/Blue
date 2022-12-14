namespace Blue.Core
{
    public class WebResponseBase<T> where T : class, IEntity, new()
    {
        public T Single { get; set; } = null!;
        public List<T> List { get; set; } = null!;
    }
}