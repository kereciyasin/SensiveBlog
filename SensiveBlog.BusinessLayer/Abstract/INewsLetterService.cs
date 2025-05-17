using SensiveBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveBlog.BusinessLayer.Abstract
{
    public interface INewsLetterService : IGenericService<NewsLetter>
    {
        // Custom methods for NewsLetter can be added here
        // For example:
        // List<NewsLetter> GetNewsLettersBySubscriptionDate(DateTime date);
    }

}
