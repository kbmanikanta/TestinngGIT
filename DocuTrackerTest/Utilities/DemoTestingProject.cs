using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocuTrackerAutomation;

namespace DocuTrackerTest
{
    public class DemoTestingProject
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
            LoginPage.GoTo();
            LoginPage.LoginAs("keerthyadmin").WithPassword("123456").Login();
        }


        [TestCleanup]
        public void Cleanup()
        {
            Driver.close();
        }
    }
}
