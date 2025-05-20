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
    public class ArticleManager : IArticleService
    {
        private readonly IArticleDal _articleDal;

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public List<Article> ArticleListWithCategoryAndAppUser()
        {
            return _articleDal.ArticleListWithCategoryAndAppUser(); // Assuming ArticleListWithCategoryAndAppUser() is implemented in the IArticleDal interface
        }

        public List<Article> TArticleListWithCategory()
        {
            return _articleDal.ArticleListWithCategory(); // Assuming ArticleListWithCategory() is implemented in the IArticleDal interface
        }

        public void TDelete(int id)
        {
            _articleDal.Delete(id); // Assuming Delete(T) is implemented in the IGenericDal interface   
        }

        public List<Article> TGetAll()
        {
            return _articleDal.GetAll(); // Assuming GetAll() is implemented in the IGenericDal interface
        }

        public List<Article> TGetAll(Func<Article, bool> filter)
        {
            return _articleDal.GetAll(); // Assuming GetAll(Func<T, bool>) is implemented in the IGenericDal interface
        }

        public Article TGetById(int id)
        {
            return _articleDal.GetById(id); // Assuming GetById(int) is implemented in the IGenericDal interface
        }

        public void TInsert(Article entity)
        {
            _articleDal.Insert(entity); // Assuming Insert(T) is implemented in the IGenericDal interface   
        }

        public void TUpdate(Article entity)
        {
            if (entity.Description != "" && entity.Title.Length >= 5 && entity.Title.Length <= 100)
            {
                _articleDal.Update(entity); // Assuming Update(T) is implemented in the IGenericDal interface  
            }
            else
            {
                throw new Exception("Article properties cannot be empty.");
            }
        }
    }
}
