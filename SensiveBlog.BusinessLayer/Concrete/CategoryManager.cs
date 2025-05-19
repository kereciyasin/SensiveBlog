using SensiveBlog.BusinessLayer.Abstract;
using SensiveBlog.DataAccesLayer.Abstract;
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
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TDelete(int id)
        {
            _categoryDal.Delete(id); // Assuming Delete(T) is implemented in the IGenericDal interface  
        }

        public List<Category> TGetAll()
        {
            return _categoryDal.GetAll(); // Assuming GetAll() is implemented in the IGenericDal interface
        }

        public List<Category> TGetAll(Func<Category, bool> filter)
        {
            return _categoryDal.GetAll(); // Assuming GetAll(Func<T, bool>) is implemented in the IGenericDal interface
        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id); // Assuming GetById(int) is implemented in the IGenericDal interface
        }

        public void TInsert(Category entity)
        {
            if (entity.CategoryName.Length >= 5 && entity.CategoryName.Length <= 50)
            {
                _categoryDal.Insert(entity); // Assuming Insert(T) is implemented in the IGenericDal interface
            }
            else
            {
                throw new Exception("Category name must be between 5 and 50 characters.");
            }
        }

        public void TUpdate(Category entity)
        {
            _categoryDal.Update(entity); // Assuming Update(T) is implemented in the IGenericDal interface  
        }
    }
}
