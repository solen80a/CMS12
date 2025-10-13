using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace Cms.Models.Pages
{
    [ContentType(
        GUID = "A1B2C3D4-E5F6-7890-1234-56789ABCDEF0",
        DisplayName = "Article Card Block",
        Description = "A block representing an article card"
    )]
    public class ArticleCardBlock : BlockData
    {
        public virtual string? Subheading { get; set; }
        public virtual string? MainBody { get; set; }
        public virtual string? ImageUrl { get; set; }
    }
}