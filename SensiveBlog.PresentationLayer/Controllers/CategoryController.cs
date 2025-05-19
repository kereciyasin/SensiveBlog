using Microsoft.AspNetCore.Mvc;
using SensiveBlog.BusinessLayer.Abstract;
using SensiveBlog.EntityLayer.Concrete;

namespace SensiveBlog.PresentationLayer.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult CategoryList()
        {
            var values = _categoryService.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
            _categoryService.TInsert(category);
            return RedirectToAction("CategoryList");
        }
        public IActionResult CategoryDelete(int id)
        {
            _categoryService.TDelete(id);
            return RedirectToAction("CategoryList");
        }
        [HttpGet]
        public IActionResult CategoryUpdate(int id)
        {
            var value = _categoryService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult CategoryUpdate(Category category)
        {
            _categoryService.TUpdate(category);
            return RedirectToAction("CategoryList");
        }

    }
}
