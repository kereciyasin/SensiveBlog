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
    public class EfNewsLetterDal : GenericRepository<NewsLetter>, INewsLetterDal
    {
        public EfNewsLetterDal(SensiveContext context) : base(context)
        {
        }
    }

}
