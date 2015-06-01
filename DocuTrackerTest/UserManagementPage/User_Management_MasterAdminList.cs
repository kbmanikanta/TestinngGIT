using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.UserManagementPage
{
    [TestClass]
    public class User_Management_MasterAdminList : DemoTestingProject
    {
        [TestMethod]
        public void MasterAdminList()
        {
            DocuTrackerAutomation.Pages.UserManagement.UserManagement.GotoMasterAdminList();
            Assert.AreEqual(DocuTrackerAutomation.Pages.UserManagement.Management.Title, "Master Admins List", "Title did not match");
        }
    }
}
