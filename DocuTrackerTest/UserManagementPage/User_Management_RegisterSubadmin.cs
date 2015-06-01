using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.UserManagementPage
{
    [TestClass]
    public class User_Management_RegisterSubadmin : DemoTestingProject
    {
        [TestMethod]
        public void RegisterSubadmin()
        {
            DocuTrackerAutomation.Pages.UserManagement.UserManagement.GotoRegisterSubadmin();
            Assert.AreEqual(DocuTrackerAutomation.Pages.UserManagement.Management.Title, "Register Koya Sub Admin", "Title did not match");
            DocuTrackerAutomation.Pages.UserManagement.UserManagement.GotoRegisterLogins();
        }
    }
}
