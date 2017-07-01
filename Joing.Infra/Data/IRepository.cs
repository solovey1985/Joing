using System;
using System.Collections.Generic;

namespace Joing.Infra.Data
{
    public interface IRepository<T> where T : class, IEntity
    {
        IContext<T> Dal { get; set; }
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        IEnumerable<T> Get(Func<T, bool> predicate);
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool DeleteById(Guid id);
    }
}
