using DocuTrackerAutomation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.AccountSettingsPage
{
    [TestClass]
    public class User_Management_ChangePassword : DemoTestingProject
    {
        [TestMethod]
        public void ChangePassword()
        {
            DocuTrackerAutomation.Pages.AccountSettings.AccountSettingsPage.GotoChangePassword();
            Assert.AreEqual(DocuTrackerAutomation.Pages.AccountSettings.SettingsPage.Title, "Change Password", "Title did not match");
            DocuTrackerAutomation.Pages.AccountSettings.AccountSettingsPage.ChangePassword();
            DocuTrackerAutomation.Driver.Currentwindowclose();

        }
    }
}
