using System.Collections.Generic;
using Masiv.Model.Models;

namespace Masiv.Data.Interfaces
{
    public interface IRepositoryBase<T>
    {
        T Create(T entity);
        T Update(T entity);
        T Delete(T entity);
        IEnumerable<T> Find(QueryFilter filters);
    }
}