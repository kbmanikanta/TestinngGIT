using DocuTrackerAutomation.Pages.ManageAgreements;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.ManageAgreementsPage
{
    [TestClass]
    public class Manage_Agreements_CreateNewPBAgreement : EmployeeLogin
    {
        [TestMethod]
        public void CreateNewPBAgreement()
        {
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.GotoCreateNewPBAgreement();
            Assert.AreEqual(ManagePage.Title, "Create PB Agreement", "Title did not match");
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.CreateNewPBAgreement();
        }
    }
}
