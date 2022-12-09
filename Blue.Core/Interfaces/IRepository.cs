namespace Blue.Core
{
    public interface IRepository<T>
    {
        Task InsertAsync(T Entity);
    }
}