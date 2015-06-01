using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.UserManagementPage
{
    [TestClass]
    public class User_Management_SubadminList : DemoTestingProject
    {
        [TestMethod]
        public void SubadminList()
        {
            DocuTrackerAutomation.Pages.UserManagement.UserManagement.GotoSubadminList();
            Assert.AreEqual(DocuTrackerAutomation.Pages.UserManagement.Management.Title, "Sub Admins List", "Title did not match");
            DocuTrackerAutomation.Pages.UserManagement.UserManagement.GotoAssignPermissions();
        }
    }
}
