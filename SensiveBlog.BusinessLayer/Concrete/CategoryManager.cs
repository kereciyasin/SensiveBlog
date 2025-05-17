using SensiveBlog.BusinessLayer.Abstract;
using SensiveBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveBlog.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        public void TDelete(Category id)
        {
            throw new NotImplementedException();
        }

        public List<Category> TGetAll()
        {
            throw new NotImplementedException();
        }

        public List<Category> TGetAll(Func<Category, bool> filter)
        {
            throw new NotImplementedException();
        }

        public Category TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Category entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
