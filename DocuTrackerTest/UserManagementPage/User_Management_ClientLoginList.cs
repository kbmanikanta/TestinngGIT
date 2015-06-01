using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.UserManagementPage
{
    [TestClass]
    public class User_Management_ClientLoginList : DemoTestingProject
    {
        [TestMethod]
        public void ClientLoginList()
        {
            DocuTrackerAutomation.Pages.UserManagement.UserManagement.GotoClientLoginList();
            Assert.AreEqual(DocuTrackerAutomation.Pages.UserManagement.Management.Title, "Client Logins", "Title did not match");
            DocuTrackerAutomation.Pages.UserManagement.UserManagement.GotoClientLoginList1();
            DocuTrackerAutomation.Driver.TurnOnWait();
            DocuTrackerAutomation.Pages.UserManagement.UserManagement.GotoClientPermissions();
        }
    }
}
