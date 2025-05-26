using SensiveBlog.BusinessLayer.Abstract;
using SensiveBlog.DataAccesLayer.Abstract;
using SensiveBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SensiveBlog.BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void TDelete(int id)
        {
            _commentDal.Delete(id); // Assuming Delete(T) is implemented in the IGenericDal interface
        }

        public List<Comment> TGetAll()
        {
            return _commentDal.GetAll(); // Assuming GetAll() is implemented in the IGenericDal interface   
        }

        public List<Comment> TGetAll(Func<Comment, bool> filter)
        {
            return _commentDal.GetAll(); // Assuming GetAll(Func<T, bool>) is implemented in the IGenericDal interface    
        }

        public Comment TGetById(int id)
        {
            return _commentDal.GetById(id); // Assuming GetById(int) is implemented in the IGenericDal interface 
        }

        public List<Comment> TGetCommentsByArticleId(int id)
        {
            return _commentDal.GetCommentsByArticleId(id); // Assuming GetCommentsByArticleId(int) is implemented in the ICommentDal interface
        }

        public void TInsert(Comment entity)
        {
            _commentDal.Insert(entity); // Assuming Insert(T) is implemented in the IGenericDal interface   
        }

        public void TUpdate(Comment entity)
        {
            _commentDal.Update(entity); // Assuming Update(T) is implemented in the IGenericDal interface   
        }
    }
}
