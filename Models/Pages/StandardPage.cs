using EPiServer.Core;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace Cms.Models.Pages
{
    [ContentType(
        GUID = "d2a1e8b2-1234-4c56-9876-abcdef123456",
        DisplayName = "Standard Page",
        Description = "A standard page type for general content"
    )]
    public class StandardPage : PageData
    {
      
        [CultureSpecific]
        [Display(
            Name = "Subheading",
            Description = "Subheading of the page",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual string? Subheading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "Main content area using the XHTML editor",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual XhtmlString? MainBody { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Image URL",
            Description = "URL to an image",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        public virtual string? ImageUrl { get; set; }
    }
}
