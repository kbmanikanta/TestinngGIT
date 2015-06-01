using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocuTrackerAutomation;

namespace DocuTrackerTest
{
    public class EmployeeLogin
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
            LoginPage.GoTo();
            LoginPage.LoginAs("sirishaemployee").WithPassword("123456").Login();
        }
        [TestCleanup]
        public void Cleanup()
        {
            Driver.close();
        }
    }
}