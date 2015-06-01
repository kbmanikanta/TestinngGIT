using DocuTrackerAutomation.Navigation;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DocuTrackerAutomation.Pages.UserManagement
{
    public class UserManagement
    {
        public static void GotoRegisterDemoClientLogin()
        {
            LeftNavigation.UserManagement.RegisterDemoClientLogin.Select();

        }

        public static void GotoDemoClientLoginList()
        {
            LeftNavigation.UserManagement.DemoClientLoginList.Select();
        }

        public static void GotoRegisterClientLogin()
        {
            LeftNavigation.UserManagement.RegisterClientLogin.Select();
        }

        public static void GotoClientLoginList()
        {
            LeftNavigation.UserManagement.ClientLoginList.Select();
        }

        public static void GotoRegisterEmployee()
        {
          LeftNavigation.UserManagement.RegisterEmployee.Select();
        }

        public static void GotoEmployeeList()
        {
            LeftNavigation.UserManagement.EmployeeList.Select();
        }

        public static void GotoVIPAccess()
        {
            LeftNavigation.UserManagement.VIPAccess.Select();
        }

        public static void GotoRegisterSubadmin()
        {
            LeftNavigation.UserManagement.RegisterSubadmin.Select();
        }

        public static void GotoSubadminList()
        {
            LeftNavigation.UserManagement.SubadminList.Select();
        }

        public static void GotoRegisterMasterAdmin()
        {
            LeftNavigation.UserManagement.RegisterMasteradmin.Select();
        }

        public static void GotoMasterAdminList()
        {
            LeftNavigation.UserManagement.MasterAdminList.Select();
        }
        public static void GotoRegisterClients()
        {
            SelectElement dropdown = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlClientList")));
            dropdown.SelectByValue("3");
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_txtUserName")).SendKeys("xxxxxx@xxxx.com");
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_txtFirstName")).SendKeys("yyyyy");
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_txtLastName")).SendKeys("zzzzz");
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_txtPhoneNo")).SendKeys("1234567890");
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_btnSubmit")).Click();
        }
       public static void GotoClientLoginList1()
        {
            SelectElement dropdown = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlClientList")));
            dropdown.SelectByValue("3");
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_btnSearch")).Click();
            Driver.TurnOnWait1();
        }
        public static void GotoClientPermissions()
        {

            var s = Driver.Instance.FindElements(By.LinkText("Set Permissions"));
            s[9].Click();//keerthyclient
            SelectElement combobox = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_listClientEntities")));
            combobox.SelectByValue("5");
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_LinkButton3")).Click();
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_btnSubmit")).Click();
        }
        public static void GotoRegisterLogins()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_txtUserName")).SendKeys("xxxxxx@xxxx.com");
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_txtFirstName")).SendKeys("yyyyy");
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_txtLastName")).SendKeys("zzzzz");
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_txtPhoneNo")).SendKeys("1234567890");
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_btnSubmit")).Click();
        }
        public static void GotoAssignPermissions()
        {

            var s = Driver.Instance.FindElements(By.LinkText("Assign Permissions"));
            s[9].Click();//manisubadmin
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_tvClientswithClientEntitiesn2CheckBox")).Click();
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_btnSubmit")).Click();
        }


    }
}
