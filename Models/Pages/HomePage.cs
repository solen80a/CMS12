using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.ServiceLocation;
using System.ComponentModel.DataAnnotations;

namespace Cms.Models.Pages
{
    [ContentType(
        GUID = "b6c15ee3-b307-4b43-916f-b9e1c10eec49",
        DisplayName = "HomePage"
        )]
    public class HomePage : PageData
    {
        [Display(Order = 100, GroupName = SystemTabNames.Content)]
        public virtual ContentArea? MainContentArea { get; set; }
        public static T Get<T>() where T : HomePage
        {
            var homePage = ServiceLocator.Current.GetInstance<IContentLoader>()
                .Get<T>(ContentReference.StartPage);
            return homePage;
        }
    }
}
