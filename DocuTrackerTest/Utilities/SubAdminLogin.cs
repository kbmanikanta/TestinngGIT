using DocuTrackerAutomation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest
{
    public class SubAdminLogin
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
            LoginPage.GoTo();
            LoginPage.LoginAs("keerthysubadmin").WithPassword("123456").Login();
        }
        [TestCleanup]
        public void Cleanup()
        {
            Driver.close();
        }
    }
}