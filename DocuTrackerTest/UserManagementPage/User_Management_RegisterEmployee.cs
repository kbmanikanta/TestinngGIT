using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.UserManagementPage
{
    [TestClass]
    public class User_Management_RegisterEmployee : DemoTestingProject
    {
        [TestMethod]
        public void RegisterEmployee()
        {
            DocuTrackerAutomation.Pages.UserManagement.UserManagement.GotoRegisterEmployee();
            Assert.AreEqual(DocuTrackerAutomation.Pages.UserManagement.Management.Title, "Register Koya Employee", "Title did not match");
            DocuTrackerAutomation.Pages.UserManagement.UserManagement.GotoRegisterLogins();
        }
    }
}
