using SensiveBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveBlog.BusinessLayer.Abstract
{
    public interface ICategoryService : IGenericService<Category>
    {
        // Custom methods for Category can be added here
        // For example:
        // List<Category> GetCategoriesByParentId(int parentId);
    }

}
