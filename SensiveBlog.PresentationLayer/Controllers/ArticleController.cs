﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SensiveBlog.BusinessLayer.Abstract;
using SensiveBlog.EntityLayer.Concrete;

namespace SensiveBlog.PresentationLayer.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;
        private readonly IAppUserService _appUserService;


        public ArticleController(IArticleService articleService, ICategoryService categoryService, IAppUserService appUserService)
        {
            _articleService = articleService;
            _categoryService = categoryService;
            _appUserService = appUserService;
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
            var values = _articleService.TArticleListWithCategoryAndAppUser();
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


            var appUserList = _appUserService.TGetAll();
            List<SelectListItem> value2 = (from x in appUserList
                                           select new SelectListItem
                                           {
                                               Text = x.Name + " " + x.Surname,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.v2 = value2;
            return View();
        }
        [HttpPost]
        public IActionResult AddArticle(Article article)
        {
            article.CreatedDate = DateTime.Now;
            _articleService.TInsert(article);
            return RedirectToAction("ArticleListWithCategoryAndAppUser");
        }

        public IActionResult DeleteArticle(int id)
        {
            _articleService.TDelete(id);
            return RedirectToAction("ArticleListWithCategoryAndAppUser");
        }
        [HttpPost]
        public IActionResult UpdateArticle(Article article)
        {
            _articleService.TUpdate(article);
            return RedirectToAction("ArticleListWithCategoryAndAppUser");
        }


        [HttpGet]
        public IActionResult UpdateArticle(int id)
        {
            var categoryList = _categoryService.TGetAll();
            List<SelectListItem> value1 = (from x in categoryList
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v1 = value1;
            var appUserList = _appUserService.TGetAll();
            List<SelectListItem> value2 = (from x in appUserList
                                           select new SelectListItem
                                           {
                                               Text = x.Name + " " + x.Surname,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.v2 = value2;
            var values = _articleService.TGetById(id);
            return View(values);
        }

        public IActionResult ArticleDetail(int id)
        {
            ViewBag.i = id;
            var value = _articleService.TGetById(id);
            return View(value);
        }



    }
}
