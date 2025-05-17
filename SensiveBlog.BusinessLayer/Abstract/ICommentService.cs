using SensiveBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveBlog.BusinessLayer.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        // Custom methods for Comment can be added here
        // For example:
        // List<Comment> GetCommentsByArticleId(int articleId);
    }

}
