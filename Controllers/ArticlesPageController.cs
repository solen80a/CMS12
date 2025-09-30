using Microsoft.AspNetCore.Mvc;
using Cms.Models.Pages;
using System.Collections.Generic;

namespace Cms.Controllers
{
    public class ArticlesPageController : Controller
    {
        public IActionResult Index()
        {
            var articlesPage = new ArticlesPage
            {
                Cards = new List<ArticleCard>
                {
                    new ArticleCard
                    {
                        Subheading = "First Article",
                        MainBody = "This is the main body of the first article.",
                        ImageUrl = "/images/article1.jpg"
                    },
                    new ArticleCard
                    {
                        Subheading = "Second Article",
                        MainBody = "This is the main body of the second article.",
                        ImageUrl = "/images/article2.jpg"
                    }
                }
            };

            return View(articlesPage);
        }
    }
}
