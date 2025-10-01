using Microsoft.AspNetCore.Mvc;
using Cms.Models.Pages;
using EPiServer.Core;
using System.Collections.Generic;

namespace Cms.Controllers
{
    public class ArticlesPageController : Controller
    {
        public ContentArea GetArticleCards()
        {
            var contentArea = new ContentArea();         

            return contentArea;
        }

        public IActionResult Index(ContentArea articleCardArea)
        {
            var articlesPage = new ArticlesPage
            {
                Cards = articleCardArea
            };

            return View(articlesPage);
        }
    }
}
