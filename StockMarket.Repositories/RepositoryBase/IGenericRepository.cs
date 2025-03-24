using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockMarket.Entities.Abstract;

namespace StockMarket.Repositories.Core
{
    public interface IGenericRepository<T> where T:class,IEntity,new()
    {
        IQueryable<T> GetAll();
        ValueTask<T> GetByIdAsync(int id);
        ValueTask<T> AddAsync(T Entity);
        void Update(T Entity);
        void Delete(T Entity);

    }
}
