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
    }
}
