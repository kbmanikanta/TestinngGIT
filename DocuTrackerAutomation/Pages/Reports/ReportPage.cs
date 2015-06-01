using OpenQA.Selenium;

namespace DocuTrackerAutomation.Pages.Reports
{
    public class ReportPage
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
        public static string Title1
        {
            get
            {
                var title = Driver.Instance.FindElement(By.TagName("h3"));
                if (title != null)
                    return title.Text;
                return string.Empty;
            }
        }
    }
}
