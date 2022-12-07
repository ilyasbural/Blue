namespace Blue.DataAccess
{
    using Core;
    using System.Threading.Tasks;
    using System.Linq.Expressions;
    using Microsoft.EntityFrameworkCore;

    public abstract class RepositoryBase<T> : IRepository<T> where T : class, IEntity, new()
    {
        protected DbContext DbContext { get; set; }
        public RepositoryBase(DbContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task AddAsync(T Entity)
        {
            await DbContext.Set<T>().AddAsync(Entity);
        }
    }
}