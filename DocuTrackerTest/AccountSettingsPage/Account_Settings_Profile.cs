using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.AccountSettingsPage
{
    [TestClass]
    public class Account_Settings_Profile : DemoTestingProject
    {
        [TestMethod]
        public void Profile()
        {
            DocuTrackerAutomation.Pages.AccountSettings.AccountSettingsPage.GotoProfile();
            Assert.AreEqual(DocuTrackerAutomation.Pages.AccountSettings.SettingsPage.Title, "Update Profile", "Title did not match");
        }
    }
}
