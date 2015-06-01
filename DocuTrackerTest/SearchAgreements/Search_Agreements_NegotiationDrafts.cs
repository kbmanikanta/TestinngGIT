using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DocuTrackerTest.SearchAgreementsPage
{
    [TestClass]
    public class Search_Agreements_NegotiationDrafts : DemoTestingProject
    {
        [TestMethod]
        public void SearchAgreementsNegotiationDrafts()
        {
            DocuTrackerAutomation.Pages.SearchAgreements.SearchAgreementsPage.Goto();
            Assert.AreEqual(DocuTrackerAutomation.Pages.SearchAgreements.SearchPage.Title, "Search Agreements - Negotiation Drafts", "Title did not match");
            DocuTrackerAutomation.Pages.SearchAgreements.SearchAgreementsPage.GotoSelect();
            DocuTrackerAutomation.Driver.TurnOnWait();
            DocuTrackerAutomation.Pages.SearchAgreements.SearchAgreementsPage.GotoSelect1();
            DocuTrackerAutomation.Driver.TurnOnWait();
            DocuTrackerAutomation.Pages.SearchAgreements.SearchAgreementsPage.GotoSelect2();
            DocuTrackerAutomation.Driver.TurnOnWait();
            DocuTrackerAutomation.Pages.SearchAgreements.SearchAgreementsPage.GotoSearchBox();
        }
    }
}
