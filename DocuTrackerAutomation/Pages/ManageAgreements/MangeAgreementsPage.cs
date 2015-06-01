using DocuTrackerAutomation.Navigation;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
//using OpenQA.Selenium.Support.UI.WebDriverWait;


namespace DocuTrackerAutomation.Pages.ManageAgreements
{
    public class MangeAgreementsPage
    {
        public static void GoTo()
        {
            LeftNavigation.ManageAgreements.CreateNewISDAAgreements.Select();

        }

        public static void Goto()
        {
            LeftNavigation.ManageAgreements.BenchMarkISDATerms.Select();
        }

        public static void GoToISDATrackingWorkflow()
        {
            LeftNavigation.ManageAgreements.ISDATrackingWorkflow.Select();
        }

        public static void GoToISDAApprovedTrackingWorkflow()
        {
            LeftNavigation.ManageAgreements.ISDAApprovedTrackingWorkflow.Select();
        }

        public static void GoToUploadISDAAgreemnts()
        {
            LeftNavigation.ManageAgreements.UploadISDAAgreements.Select();
        }

        public static void GotoCreateISDANegotiationDrafts()
        {
            LeftNavigation.ManageAgreements.CreateISDANegotiationDrafts.Select();
        }

        public static void GotoISDANegotiationDraftWorkflow()
        {
            LeftNavigation.ManageAgreements.ISDANegotiationDraftTrackingWorkflow.Select();
        }

        public static void GotoCreateNewPBAgreement()
        {
            LeftNavigation.ManageAgreements.CreateNewPBAgreement.Select();
        }

        public static void BenchmarkPBTerms()
        {
            LeftNavigation.ManageAgreements.BenchmarkPBTerms.Select();
        }

        public static void PBAgreementTrackingWorkflow()
        {
            LeftNavigation.ManageAgreements.PBAgreementTrackingWorkflow.Select();
        }

        public static void PBApprovedTrackingWorkflow()
        {
            LeftNavigation.ManageAgreements.PBApprovedTrackingWorkflow.Select();
        }

        public static void UploadPBAgreements()
        {
            LeftNavigation.ManageAgreements.UploadPBAgreements.Select();
        }

        public static void CreateNewPBNegotiationDraft()
        {
            LeftNavigation.ManageAgreements.CreatePBNegotiationDraft.Select();
        }

        public static void PBNegotiationDraftWorkflow()
        {
            LeftNavigation.ManageAgreements.PBNegotiationDraftWorkflow.Select();
        }

        public static void TemplateAgreementTerms()
        {
            LeftNavigation.ManageAgreements.TemplateAgreementTerms.Select();
        }
        public static void CopyTemplatetoTemplate()
        {
            LeftNavigation.ManageAgreements.CopyTemplatetoTemplate.Select();
        }
        public static void CreateNewISDAAgreement()
        {
            SelectElement dropdown = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlCounterParty")));
            dropdown.SelectByValue("57");
            SelectElement dropdown1 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlClient")));
            dropdown1.SelectByValue("3");
            Driver.TurnOnWait1();
            SelectElement dropdown2 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlClientEntities")));
            dropdown2.SelectByValue("5");
            SelectElement dropdown3 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddFormofISDA")));
            dropdown3.SelectByValue("2002");
            SelectElement dropdown4 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddl_mm")));
            dropdown4.SelectByValue("3");
            SelectElement dropdown5 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddl_dd")));
            dropdown5.SelectByValue("14");
            SelectElement dropdown6 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddl_yyyy")));
            dropdown6.SelectByValue("2015");
            SelectElement dropdown7 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddSignedCP")));
            dropdown7.SelectByValue("Yes");
            SelectElement dropdown8 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddSignedCE")));
            dropdown8.SelectByValue("Yes");
            SelectElement dropdown9 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddStrength")));
            dropdown9.SelectByValue("Strong");
            SelectElement dropdown10 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddPartyA")));
            dropdown10.SelectByValue("1");
            SelectElement dropdown11 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddPartyB")));
            dropdown11.SelectByValue("3");
            SelectElement dropdown12 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddAgreementslist")));
            dropdown12.SelectByValue("Not Applicable");
        
        }
        public static void CreateNewPBAgreement()
        {
            SelectElement dropdown = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlPBEntity")));
            dropdown.SelectByValue("41");
            SelectElement dropdown1 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlClient")));
            dropdown1.SelectByValue("3");
            Driver.TurnOnWait1();
            SelectElement dropdown2 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlClientEntities")));
            dropdown2.SelectByValue("20");
            SelectElement dropdown3 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddFormofPrimeBroker")));
            dropdown3.SelectByValue("International");
            SelectElement dropdown4 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddl_mm")));
            dropdown4.SelectByValue("3");
            SelectElement dropdown5 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddl_dd")));
            dropdown5.SelectByValue("16");
            SelectElement dropdown6 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddl_yyyy")));
            dropdown6.SelectByValue("2015");
            SelectElement dropdown7 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddSignedPB")));
            dropdown7.SelectByValue("Yes");
            SelectElement dropdown8 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddSignedCE")));
            dropdown8.SelectByValue("Yes");
            SelectElement dropdown9 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddStrength")));
            dropdown9.SelectByValue("Strong");
            SelectElement dropdown10 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddAgreementslist")));
            dropdown10.SelectByValue("Not Applicable");
        }

        public static void SelectDropDowns()
        {
            SelectElement dropdown = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlClient")));
            dropdown.SelectByValue("3");
            Driver.TurnOnWait1();
            SelectElement dropdown1 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlClientEntity")));
            dropdown1.SelectByValue("Select All Client Entities");
            SelectElement dropdown2 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlCounterparty")));
            dropdown2.SelectByValue("Select All Counterparties");
            Driver.Instance.FindElement(By.Id("selectAll")).Click();
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_Submit")).Click();
     }
        public static void GotoSelectDropDowns()
        {
            SelectElement dropdown = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlClient")));
            dropdown.SelectByValue("3");
            Driver.TurnOnWait1();
            SelectElement dropdown1 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlClientEntity")));
            dropdown1.SelectByValue("Select All Client Entities");
            SelectElement dropdown2 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlCounterparty")));
            dropdown2.SelectByValue("Select All Counterparties");
            Driver.Instance.FindElement(By.Id("selectAll")).Click();
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_btnSubmit")).Click();
        }
            public static void UploadDocuments()
         {
            Driver.Instance.FindElement(By.XPath("//a[@class='applytoAnchor']")).Click();
            Driver.TurnOnWait();
            SelectElement dropdown = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlDocumentCategory")));
            dropdown.SelectByValue("International");
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_txtDocumentTitle")).SendKeys("siri testing");
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_txtDesc")).SendKeys("ok");
          }
            public static void GotoSearchBox()
            {
                Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_txtSearchTerm")).SendKeys("bank");
                Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_btnSubmit")).Click();
            }
        public static void GotoCreateNewISDADraft()
            {
                SelectElement dropdown = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlCounterParty")));
                dropdown.SelectByValue("57");
                SelectElement dropdown1 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlClient")));
                dropdown1.SelectByValue("3");
                Driver.TurnOnWait1();
                SelectElement dropdown2 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlClientEntities")));
                dropdown2.SelectByValue("5");
                SelectElement dropdown3 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddl_mm")));
                dropdown3.SelectByValue("3");
                SelectElement dropdown4 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddl_dd")));
                dropdown4.SelectByValue("14");
                SelectElement dropdown5 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddl_yyyy")));
                dropdown5.SelectByValue("2015");
                SelectElement dropdown6 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddFormofISDA")));
                dropdown6.SelectByValue("2002");
                Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_btnSubmit")).Click();
            }
            public static void GotoCreateNewDraftVersion()
        {
            SelectElement dropdown = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddl_mm")));
            dropdown.SelectByValue("3");
            SelectElement dropdown1 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddl_dd")));
            dropdown1.SelectByValue("14");
            SelectElement dropdown2 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddl_yyyy")));
            dropdown2.SelectByValue("2015");
            SelectElement dropdown3 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_dfParty")));
            dropdown3.SelectByValue("3");
            SelectElement dropdown4 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddAgreementslist")));
            dropdown4.SelectByValue("Not Applicable");
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_btnSubmit")).Click();
        }
        public static void GotoCreateNewPBDraft()
            {
                SelectElement dropdown = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlCounterParty")));
                dropdown.SelectByValue("57");
                SelectElement dropdown1 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlClient")));
                dropdown1.SelectByValue("3");
                Driver.TurnOnWait1();
                SelectElement dropdown2 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlClientEntities")));
                dropdown2.SelectByValue("5");
                SelectElement dropdown3 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddl_mm")));
                dropdown3.SelectByValue("3");
                SelectElement dropdown4 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddl_dd")));
                dropdown4.SelectByValue("14");
                SelectElement dropdown5 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddl_yyyy")));
                dropdown5.SelectByValue("2015");
                SelectElement dropdown6 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddFormofPrimeBroker")));
                dropdown6.SelectByValue("International");
                Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_btnSubmit")).Click();
            }
      public static void GotoBenchmarkPage()
        {
            SelectElement dropdown = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlClient")));
            dropdown.SelectByValue("3");
            SelectElement dropdown1 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlClientEntityList")));
            dropdown1.SelectByValue("5");
            Driver.TurnOnWait();
        }
      public static void GotoTemplatePage()
      {
          SelectElement dropdown = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlAgreementType")));
          dropdown.SelectByValue("1");//1-For ISDA,4-For PB
          SelectElement dropdown1 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlCounterPartyList")));
          dropdown1.SelectByValue("1");
          Driver.TurnOnWait();
      }
        public static void GotoCopyTemplatePage()
      {
          SelectElement dropdown = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlAgreementType")));
          dropdown.SelectByValue("1");//1-For ISDA,4-For PB
          SelectElement dropdown1 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlCounterpartySourceList")));
          dropdown1.SelectByValue("57");
          SelectElement dropdown2 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlCounterpartyTargetList")));
          dropdown2.SelectByValue("1");
          Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_btncopy")).Click();
      }
        }
            

           
}
       
    
