using StockMarket.Entities.Abstract;

namespace StockMarket.Repositories.GenericRepositoryBase
{
    public interface IGenericRepository<T> where T : class, IEntity, new()
    {
        IQueryable<T> GetAll();
        ValueTask<T> GetByIdAsync(int id);
        ValueTask<T> AddAsync(T Entity);
        void Update(T Entity);
        void Delete(T Entity);

    }
}
