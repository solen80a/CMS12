using System.Collections.Generic;

namespace Cms.Models.Pages
{
    [ContentType(
        GUID = "3A16460C-B42B-4A4D-AA8C-79EEC75802AA",
        DisplayName = "Articles Page",
        Description = "A page containing multiple article cards"
    )]
    public class ArticlesPage
    {
        public List<ArticleCard> Cards { get; set; } = new();
    }
}
