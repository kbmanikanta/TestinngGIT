using DocuTrackerAutomation.Pages.ManageAgreements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocuTrackerTest.Client_Tests.ManageAgreementPages
{
    [TestClass]
    public class ManageAgreements_CreateNewISDAAgreement : ClientLogin
    {
        [TestMethod]
        public void ManageAgreementsCreateNewISDA()
        {
            DocuTrackerAutomation.Pages.ManageAgreements.MangeAgreementsPage.GoTo();
            Assert.AreEqual(ManagePage.Title, "Create ISDA Master Agreement", "Title did not match");

        }
    }
}
