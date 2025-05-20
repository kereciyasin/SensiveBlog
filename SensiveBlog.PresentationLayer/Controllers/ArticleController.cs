using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SensiveBlog.BusinessLayer.Abstract;

namespace SensiveBlog.PresentationLayer.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;


        public ArticleController(IArticleService articleService, ICategoryService categoryService)
        {
            _articleService = articleService;
            _categoryService = categoryService;
        }

        public IActionResult ArticleList()
        {
            var values = _articleService.TGetAll();
            return View(values);
        }
        public IActionResult ArticleListWithCategory()
        {
            var values = _articleService.TArticleListWithCategory();
            return View(values);
        }
        public IActionResult ArticleListWithCategoryAndAppUser()
        {
            var values = _articleService.ArticleListWithCategoryAndAppUser();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddArticle()
        {
            var categoryList = _categoryService.TGetAll();
            List<SelectListItem> value1 = (from x in categoryList
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v1 = value1;

            return View();
        }

    }
}
