﻿using Microsoft.AspNetCore.Mvc;
using SensiveBlog.BusinessLayer.Abstract;

namespace SensiveBlog.PresentationLayer.ViewComponents.ArticleDetails
{
    public class _ArticleDetailListComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;

        public _ArticleDetailListComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke(int id)
        {
            id = 1;
            var value = _articleService.TGetById(id);
            return View(value);
        }
    }
}
