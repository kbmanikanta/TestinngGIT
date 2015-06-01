using OpenQA.Selenium;

namespace DocuTrackerAutomation.Navigation
{
    public class MenuSelector
    {
        public static void Select(string TopLevelMenuId, string SubMenu1)
        {
            Driver.Instance.FindElement(By.LinkText(TopLevelMenuId)).Click();
            Driver.Instance.FindElement(By.LinkText(SubMenu1)).Click();
        }

        public static void Select(string TopLevelMenuId, string SubMenu1, string SubMenu11)
        {
            Driver.Instance.FindElement(By.LinkText(TopLevelMenuId)).Click();
            Driver.Instance.FindElement(By.LinkText(SubMenu1)).Click();
            Driver.Instance.FindElement(By.LinkText(SubMenu11)).Click();
        }
        public static void Select(string Menu)
        {
            //Driver.Instance.FindElement(By.PartialLinkText("Alpha Advisors LLC"));
            //Driver.Instance.FindElement(By.LinkText(Menu)).Click();
            var rep = Driver.Instance.FindElements(By.LinkText(Menu));
            rep[0].Click();
        }
        public static void Select1(string Menu)
        {
            //Driver.Instance.FindElement(By.PartialLinkText("Alpha Advisors LLC"));
            Driver.Instance.FindElement(By.Id(Menu)).Click();
        }
    }
}
