using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using Repository.Interface;

namespace Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {

        private AppDbContext entities = null;


        public Repository(AppDbContext _entities)
        {
            entities = _entities;
            entities.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return entities.Set<T>();

        }

        public T Get(Func<T, bool> predicate)
        {
            return entities.Set<T>().First(predicate);
        }

        public void Add(T entity)
        {
            entities.Set<T>().Add(entity);
        }
        public void Update(T entity)
        {
            entities.Set<T>().Update(entity);
        }


        public void Delete(T entity)
        {
            entities.Set<T>().Remove(entity);
        }
        public void Save()
        {
            entities.SaveChanges();
        }
    }
}
