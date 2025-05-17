using SensiveBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveBlog.BusinessLayer.Abstract
{
    public interface IArticleService : IGenericService<Article>
    {
        // Custom methods for Article can be added here
        // For example:
        // List<Article> GetArticlesByCategoryId(int categoryId);
    }

}
