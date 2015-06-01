using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.UserManagementPage
{
    [TestClass]
    public class User_Management_DemoClientLoginList : DemoTestingProject
    {
        [TestMethod]
        public void DemoClientLoginList()
        {
            DocuTrackerAutomation.Pages.UserManagement.UserManagement.GotoDemoClientLoginList();
            Assert.AreEqual(DocuTrackerAutomation.Pages.UserManagement.Management.Title, "Client Logins", "Title did not match");
        }
    }
}
