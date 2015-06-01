using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DocuTrackerTest.SearchAgreementsPage
{
    namespace DocuTrackerTest.Client_Tests.SearchPages
    {
        [TestClass]
       public class Search_Agreements_Executed_Client : ClientLogin
        {
       [TestMethod]
        public void SearchAgreementsExecuted()
        {
            DocuTrackerAutomation.Pages.SearchAgreements.SearchAgreementsPage.GoTo();
            Assert.AreEqual(DocuTrackerAutomation.Pages.SearchAgreements.SearchPage.Title, "Search Agreements - Executed Agreements", "Title did not match");

            DocuTrackerAutomation.Pages.SearchAgreements.SearchAgreementsPage.GotoSelectAgreementStyle();
            DocuTrackerAutomation.Driver.TurnOnWait();
            DocuTrackerAutomation.Pages.SearchAgreements.SearchAgreementsPage.GotoSelectAgreementStyle1();
            DocuTrackerAutomation.Driver.TurnOnWait();
            DocuTrackerAutomation.Pages.SearchAgreements.SearchAgreementsPage.GotoSelectAgreementStyle2();
            DocuTrackerAutomation.Driver.TurnOnWait();
            DocuTrackerAutomation.Pages.SearchAgreements.SearchAgreementsPage.GotoSearchBox();
       }

    }
}
}