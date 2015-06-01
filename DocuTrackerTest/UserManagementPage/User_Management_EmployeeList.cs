using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.UserManagementPage
{
    [TestClass]
    public class User_Management_EmployeeList : DemoTestingProject
    {
        [TestMethod]
        public void EmployeeList()
        {
            DocuTrackerAutomation.Pages.UserManagement.UserManagement.GotoEmployeeList();
            Assert.AreEqual(DocuTrackerAutomation.Pages.UserManagement.Management.Title, "Employees List", "Title did not match");
            DocuTrackerAutomation.Pages.UserManagement.UserManagement.GotoAssignPermissions();
        }
    }
}
