using DocuTrackerAutomation.Pages.ManageAgreements;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.Client_Tests.ManageAgreementPages
{
    [TestClass]
    public class ManageAgreement_CreateNewPBAgreement : ClientLogin
    {
    [TestMethod]
        public void CreateNewPBAgreement()
        {
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.GotoCreateNewPBAgreement();
            Assert.AreEqual(ManagePage.Title, "Create PB Agreement", "Title did not match");
        }
    }
}
