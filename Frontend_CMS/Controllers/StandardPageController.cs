using Cms.Models.Pages;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace Cms.Controllers
{
    public class StandardPageController : PageController<StandardPage>
    {
        public IActionResult Index(StandardPage currentPage)
        {
            return View(currentPage);
        }
    }
}