using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorOfContext.Framework
{
    public class Repository<T, C> : IRepository<T> where T : class where C : DbContext
    {
        protected C contexto;

        public Repository()
        {
            contexto = (C)Activator.CreateInstance(typeof(C));
        }

        public void Delete(T obj)
        {
            contexto.Set<T>().Remove(obj);
            contexto.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return contexto.Set<T>().ToList();
        }

        public T GetOne(T obj)
        {
            return contexto.Set<T>().Find(obj);
        }

        public T GetOneId(long id)
        {
            return contexto.Set<T>().Find(id);
        }

        public void Save(T obj)
        {
            contexto.Set<T>().Add(obj);
            contexto.SaveChanges();
        }

        public void Update(T obj)
        {
            contexto.Entry(obj).State = EntityState.Modified;
            contexto.SaveChanges();
        }
    }
}
