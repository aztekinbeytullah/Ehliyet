using BLL.Abstract;
using DAL.Abstract;
using DAL.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class CategoryManager : ICategoryServices
    {
        ICategoryDal _categoryDal;
    
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal=categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetList();
        }

        public void Remove(Category category)
        {
            _categoryDal.Remove(category);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
