using DocuTrackerAutomation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest
{
    [TestClass]
    public class LoginTest : DemoTestingProject
    {
        [TestMethod]
        public void Admin_Login()
        {
            Assert.AreEqual(DashboardPage.Title, "Dashboard", "Failed to Login");
        }
    }
}
