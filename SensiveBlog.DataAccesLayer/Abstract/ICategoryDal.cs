using SensiveBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveBlog.DataAccesLayer.Abstract
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        // Custom methods for Category can be added here if needed
    }

}
