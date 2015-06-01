using DocuTrackerAutomation.Navigation;
using OpenQA.Selenium;

namespace DocuTrackerAutomation.Pages.AccountSettings
{
    public class AccountSettingsPage
    {
        public static void GotoProfile()
        {
            LeftNavigation.AccountSettings.Profile.Select();
        }

        public static void GotoChangePassword()
        {
            LeftNavigation.AccountSettings.ChangePassword.Select();
        }
        public static void ChangePassword()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_txtOldPassword")).SendKeys("123456");
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_txtNewPassword")).SendKeys("654321");
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_txtConfirmPassword")).SendKeys("654321s");
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_btnSubmit")).Click();
        }
    }
}


