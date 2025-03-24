using Microsoft.EntityFrameworkCore;
using StockMarket.Entities.Abstract;
using StockMarket.Repositories.DbContexts;

namespace StockMarket.Repositories.GenericRepositoryBase
{
    public class GenericRepository<T>(AppDbContext context) : IGenericRepository<T> where T : class, IEntity, new()
    {
        private readonly DbSet<T> _dbSet;
        public async ValueTask AddAsync(T Entity)
        {
            await _dbSet.AddAsync(Entity);
        }

        public void Delete(T Entity)
        {
            _dbSet.Remove(Entity);
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet.AsQueryable();
        }

        public ValueTask<T> GetByIdAsync(int id)
        {
            return _dbSet.FindAsync(id);
        }

        public void Update(T Entity)
        {
            _dbSet.Update(Entity);
        }
    }
}
