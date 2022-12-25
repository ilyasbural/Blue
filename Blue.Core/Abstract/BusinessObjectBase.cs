namespace Blue.Core
{
    public abstract class BusinessObjectBase<T> where T : class, IEntity, new()
    {
        protected T Entity { get; set; } = null!;
        protected List<T> Collection { get; set; } = null!;
        protected int Result { get; set; } = 0;
        protected int Success { get; set; } = 0;
        protected string Message { get; set; } = null!;
        protected bool IsValidationError { get; set; } = false;
    }
}