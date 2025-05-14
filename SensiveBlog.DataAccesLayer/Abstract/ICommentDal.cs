using SensiveBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveBlog.DataAccesLayer.Abstract
{
    public interface ICommentDal : IGenericDal<Comment>
    {
        // Custom methods for Comment can be added here if needed
    }

}
