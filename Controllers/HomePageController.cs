using Cms.Models.Pages;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace Cms.Controllers
{
    public class HomePageController : PageController<HomePage>

    {
        public IActionResult Index(HomePage currentpage)
        {
            var homePage = HomePage.Get<HomePage>();
            var model = new BaseModel<HomePage> { Page = homePage };
            return View(model);

            //return View(currentpage);
        }
    }
}
