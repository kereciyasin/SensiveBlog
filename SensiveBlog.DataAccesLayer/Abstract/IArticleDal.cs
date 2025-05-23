using SensiveBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveBlog.DataAccesLayer.Abstract
{
    public interface IArticleDal : IGenericDal<Article>
    {
        // Custom methods for Article can be added here if needed
        List<Article> ArticleListWithCategory();
        List<Article> ArticleListWithCategoryAndAppUser();
        Article GetLastArticle();
    }

}
