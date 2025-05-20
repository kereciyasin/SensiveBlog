using Microsoft.EntityFrameworkCore;
using SensiveBlog.DataAccesLayer.Abstract;
using SensiveBlog.DataAccesLayer.Context;
using SensiveBlog.DataAccesLayer.Repositories;
using SensiveBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveBlog.DataAccesLayer.EntityFramework
{
    public class EfArticleDal : GenericRepository<Article>, IArticleDal
    {
        public EfArticleDal(SensiveContext context) : base(context)
        {
        }

        public List<Article> ArticleListWithCategory()
        {
            var context = new SensiveContext();
            var values = context.Articles.Include(x => x.Category).ToList();
            return values;
        }

        public List<Article> ArticleListWithCategoryAndAppUser()
        {
            var context = new SensiveContext();
            var values = context.Articles.Include(x => x.Category).Include(x => x.AppUser).ToList();
            return values;
        }
    }

}
