using OpenQA.Selenium;

namespace DocuTrackerAutomation
{
    public class LoginPage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress + "NewClient.aspx");
        }
        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }
        public class LoginCommand
        {
            private readonly string userName;
            private string password;

            public LoginCommand(string userName)
            {
                this.userName = userName;
            }

            public LoginCommand WithPassword(string password)
            {
                this.password = password;
                return this;
            }

            public void Login()
            {
                var loginInput = Driver.Instance.FindElement(By.Id("txtUserName"));
                loginInput.SendKeys(userName);

                var passwordInput = Driver.Instance.FindElement(By.Id("txtPassword"));
                passwordInput.SendKeys(password);

                var loginButton = Driver.Instance.FindElement(By.Id("btnSubmit"));
                loginButton.Click();
            }
        }
    }
}
