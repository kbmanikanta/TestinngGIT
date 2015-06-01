using OpenQA.Selenium;

namespace DocuTrackerAutomation.Pages.UserManagement
{
    public class Management
    {
        public static string Title
        {
            get
            {
                var title = Driver.Instance.FindElement(By.TagName("h1"));
                if (title != null)
                    return title.Text;
                return string.Empty;
            }
        }
    }
}
