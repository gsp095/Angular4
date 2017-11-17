using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interface
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(Func<T, bool> predicate);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();

    }
}
