using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorOfContext.Framework
{
    public interface IRepository<T> where T : class
    {
        void Save(T obj);
        void Update(T obj);
        void Delete(T obj);
        T GetOneId(long id);
        T GetOne(T obj);
        IEnumerable<T> GetAll();
    }
}
