using DocuTrackerAutomation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest
{
    public class ClientLogin
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
            LoginPage.GoTo();
            LoginPage.LoginAs("keerthyclient").WithPassword("123456").Login();
        }
        [TestCleanup]
        public void Cleanup()
        {
            Driver.close();
        }
    }
}