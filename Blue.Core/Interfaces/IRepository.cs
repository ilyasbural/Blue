namespace Blue.Core
{
    public interface IRepository<T>
    {
        Task AddAsync(T Entity);
    }
}