using DAL.Abstract;
using DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Add(T T)
        {
            using (MyDbContext c = new MyDbContext())
            {
                c.Add(T);
                c.SaveChanges();
            }
        }

        public T GetById(int id)
        {
            using (MyDbContext c = new MyDbContext())
            {
                return c.Set<T>().Find(id);
            }
        }

        public List<T> GetList()
        {
            using (MyDbContext c = new MyDbContext())
            {
                return c.Set<T>().ToList();
            }
        }

        public void Remove(T T)
        {
            using (MyDbContext c = new MyDbContext())
            {
                c.Remove(T);
                c.SaveChanges();
            }
        }

        public void Update(T T)
        {
            using (MyDbContext c = new MyDbContext())
            {
                c.Update(T);
                c.SaveChanges();
            }
        }
    }
}
