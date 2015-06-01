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
        public class Search_Agreements_NegotiationDrafts_Client : ClientLogin
        {
            public void SearchAgreementsNegotiationDrafts()
            {
                DocuTrackerAutomation.Pages.SearchAgreements.SearchAgreementsPage.Goto();
                Assert.AreEqual(DocuTrackerAutomation.Pages.SearchAgreements.SearchPage.Title, "Search Agreements - Negotiation Drafts", "Title did not match");
               

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
