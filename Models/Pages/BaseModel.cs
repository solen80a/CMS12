using System.ComponentModel.DataAnnotations;

namespace Cms.Models.Pages
{
    //[ContentType(
    //       GUID = "54EBC94C-07DD-4C7A-96D6-B3E46B7B0630",
    //       DisplayName = "BaseHTML"
    //       )]
    public class BaseModel<HomePage>
    {
        [Display(Order = 100, GroupName = SystemTabNames.Content)]
        public virtual ContentArea? GetContentArea { get; set; }
        public object? Page { get; internal set; }
    }
}
