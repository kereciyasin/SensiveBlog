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
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public EfCommentDal(SensiveContext context) : base(context)
        {
        }

        public List<Comment> GetCommentsByArticleId(int Id)
        {
            var context = new SensiveContext();
            var values = context.Comments.Where(x => x.ArticleId == Id).Include(y => y.Article).Include(z => z.AppUser).ToList();
            return values;
        }

    }
}