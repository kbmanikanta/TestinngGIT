using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.UserManagementPage
{
    [TestClass]
    public class User_Management_RegisterMasterAdmin : DemoTestingProject
    {
        [TestMethod]
        public void RegisterMasterAdmin()
        {
            DocuTrackerAutomation.Pages.UserManagement.UserManagement.GotoRegisterMasterAdmin();
            Assert.AreEqual(DocuTrackerAutomation.Pages.UserManagement.Management.Title, "Register Koya Master Admin", "Title did not match");
            DocuTrackerAutomation.Pages.UserManagement.UserManagement.GotoRegisterLogins();
        }
    }
}
