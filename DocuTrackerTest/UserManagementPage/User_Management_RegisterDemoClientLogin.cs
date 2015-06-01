using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.UserManagementPage
{
    [TestClass]
    public class User_Management_RegisterDemoClientLogin : DemoTestingProject
    {
        [TestMethod]
        public void RegisterDemoClientLogin()
        {
            DocuTrackerAutomation.Pages.UserManagement.UserManagement.GotoRegisterDemoClientLogin();
            Assert.AreEqual(DocuTrackerAutomation.Pages.UserManagement.Management.Title, "Create Demo Client Login", "Title did not match");
            DocuTrackerAutomation.Pages.UserManagement.UserManagement.GotoRegisterClients();
            DocuTrackerAutomation.Driver.TurnOnWait();
        }
    }
}
