using Microsoft.AspNetCore.Mvc;
using SensiveBlog.BusinessLayer.Abstract;

namespace SensiveBlog.PresentationLayer.ViewComponents.ArticleDetails
{
    public class _ArticleDetailCommentListComponentPartial : ViewComponent
    {
        private readonly ICommentService _commentService;

        public _ArticleDetailCommentListComponentPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }
        public IViewComponentResult Invoke()
        {
            var value = _commentService.TGetById(1); // Assuming you want to get comments for article with ID 1
            return View(value);
        }
    }
}
