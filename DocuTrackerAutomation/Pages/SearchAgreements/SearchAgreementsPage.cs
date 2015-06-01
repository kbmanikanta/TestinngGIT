using DocuTrackerAutomation.Navigation;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DocuTrackerAutomation.Pages.SearchAgreements
{
    public class SearchAgreementsPage
    {
        public static void GoTo()
        {
            LeftNavigation.SearchAgreements.ExecutedAgreements.Select();
        }

        public static void Goto()
        {
            LeftNavigation.SearchAgreements.NegotiationDrafts.Select();
        }
        public static void GotoSelectAgreementStyle()
        {
            SelectElement dropdown = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddAgreementType")));
            dropdown.SelectByValue("All Agreements");
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_chkCECP")).Click();
            }
        public static void GotoSelectAgreementStyle1()
        {
            SelectElement dropdown1 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddAgreementType")));
            dropdown1.SelectByValue("ISDA Agreements");
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_chkCECP")).Click();
        }
        public static void GotoSelectAgreementStyle2()
        {
            SelectElement dropdown1 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddAgreementType")));
            dropdown1.SelectByValue("Prime Brokerage Agreements");
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_chkCECP")).Click();
        }
        public static void GotoSearchBox()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_txtSearchTerm")).SendKeys("bank");
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_btnSubmit")).Click();
        }
        public static void GotoSelect()
        {
            SelectElement dropdown = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlClient")));
            dropdown.SelectByValue("3");
            SelectElement dropdown1 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddAgreementType")));
            dropdown1.SelectByValue("All Agreements");
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_chkCECP")).Click();
        }
        public static void GotoSelect1()
        {
            SelectElement dropdown = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlClient")));
            dropdown.SelectByValue("3");
            SelectElement dropdown1 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddAgreementType")));
            dropdown1.SelectByValue("ISDA Agreements");
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_chkCECP")).Click();
        }
        public static void GotoSelect2()
        {
            SelectElement dropdown = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlClient")));
            dropdown.SelectByValue("3");
            SelectElement dropdown1 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddAgreementType")));
            dropdown1.SelectByValue("Prime Brokerage Agreements");
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_chkCECP")).Click();
        }
    }
}
