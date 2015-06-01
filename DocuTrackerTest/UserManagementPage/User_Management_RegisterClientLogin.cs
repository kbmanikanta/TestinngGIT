using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.UserManagementPage
{
    [TestClass]
    public class User_Management_RegisterClientLogin : DemoTestingProject
    {
        [TestMethod]
        public void RegisterClientLogin()
        {
            DocuTrackerAutomation.Pages.UserManagement.UserManagement.GotoRegisterClientLogin();
            Assert.AreEqual(DocuTrackerAutomation.Pages.UserManagement.Management.Title, "Create Client Login", "Title did not match");
            DocuTrackerAutomation.Pages.UserManagement.UserManagement.GotoRegisterClients();
            DocuTrackerAutomation.Driver.TurnOnWait();
        }
    }
}
