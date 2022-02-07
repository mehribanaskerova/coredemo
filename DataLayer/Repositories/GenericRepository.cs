using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Insert(T t)
        {
            using var context = new ContextSQLServer();
            context.Add(t);
            context.SaveChanges();
        }

        public void Delete(T t)
        {
            using var context = new ContextSQLServer();
            context.Remove(t);
            context.SaveChanges();
        }

        public T GetbyID(int id)
        {
            using var context = new ContextSQLServer();
            return context.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using var context = new ContextSQLServer();
            return context.Set<T>().ToList();
        }

        public void Update(T t)
        {
            using var context = new ContextSQLServer();
            context.Update(t);
            context.SaveChanges();
        }
    }
}
