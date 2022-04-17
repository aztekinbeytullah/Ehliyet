using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public  interface IGenericServices<T>
    {
        void Add(T TEntity);
        void Remove(T TEntity);
        void Update(T TEntity);
        List<T> GetList();
        T GetById(int id);
    }
}
