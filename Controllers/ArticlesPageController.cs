using Microsoft.AspNetCore.Mvc;
using Cms.Models.Pages;
using EPiServer.Web.Mvc;

namespace Cms.Controllers
{
    public class ArticlesPageController : PageController<ArticlesPage>
    {
        public ActionResult Index(ArticlesPage currentPage)
        {
            return View(currentPage);
        }
    }
}
