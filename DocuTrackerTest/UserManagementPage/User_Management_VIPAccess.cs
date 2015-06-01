using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.UserManagementPage
{
    [TestClass]
    public class User_Management_VIPAccess : DemoTestingProject
    {
        [TestMethod]
        public void VIPAccess()
        {
            DocuTrackerAutomation.Pages.UserManagement.UserManagement.GotoVIPAccess();
            Assert.AreEqual(DocuTrackerAutomation.Pages.UserManagement.Management.Title, "Employees", "Title did not match");
        }
    }
}
