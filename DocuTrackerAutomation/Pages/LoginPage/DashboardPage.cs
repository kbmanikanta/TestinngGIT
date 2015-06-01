using OpenQA.Selenium;

namespace DocuTrackerAutomation
{
    public class DashboardPage
    {
        public static string Title
        {
            get
            {
                var title = Driver.Instance.FindElement(By.ClassName("table-header"));
                if (title != null)
                    return title.Text;
                return string.Empty;
            }
        }
    }
}
