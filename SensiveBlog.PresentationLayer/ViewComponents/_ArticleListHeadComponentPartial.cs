﻿using Microsoft.AspNetCore.Mvc;

namespace SensiveBlog.PresentationLayer.ViewComponents
{
    public class _ArticleListHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
