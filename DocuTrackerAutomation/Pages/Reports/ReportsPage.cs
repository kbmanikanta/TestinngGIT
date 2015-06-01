using DocuTrackerAutomation.Navigation;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace DocuTrackerAutomation.Pages.Reports
{
    public class ReportsPage
    {
        public static void GotoISDAReports()
        {
            LeftNavigation.Reports.ISDAReports.Select();
        }

        public static void GotoPBReports()
        {
            LeftNavigation.Reports.PBReports.Select();
        }

        public static void GotoGenerateReport()
        {
            LeftNavigation.Reports.GenerateReport.Select();
        }

        public static void GotoSavedReport()
        {
            LeftNavigation.Reports.SavedReports.Select();
        }

        public static void GotoCustomReports()
        {
            LeftNavigation.Reports.CustomReports.Select();
        }

        public static void GotoSteponeReport()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_chkExec_0")).Click());
            SelectElement dropdown1 = new SelectElement(Driver.Instance.FindElement(By.Id("ddAgreementStyle")));
            dropdown1.SelectByValue("All types");
            SelectElement dropdown2 = new SelectElement(Driver.Instance.FindElement(By.Id("ddlClientEntities")));
            dropdown2.SelectByValue("All Client Entities");
        }

        public static void GotoSteponeReport1()
        {
            SelectElement dropdown = new SelectElement(Driver.Instance.FindElement(By.Id("ddAgreementType")));
            dropdown.SelectByValue("1");
            SelectElement dropdown1 = new SelectElement(Driver.Instance.FindElement(By.Id("ddAgreementStyle")));
            dropdown1.SelectByValue("All types");
            SelectElement dropdown2 = new SelectElement(Driver.Instance.FindElement(By.Id("ddlClientEntities")));
            dropdown2.SelectByValue("All Client Entities");
        }
        public static void GotoSteponeReport2()
        {
            SelectElement dropdown = new SelectElement(Driver.Instance.FindElement(By.Id("ddAgreementType")));
            dropdown.SelectByValue("4");
            SelectElement dropdown1 = new SelectElement(Driver.Instance.FindElement(By.Id("ddAgreementStyle")));
            dropdown1.SelectByValue("All types");
            SelectElement dropdown2 = new SelectElement(Driver.Instance.FindElement(By.Id("ddlClientEntities")));
            dropdown2.SelectByValue("All Client Entities");
        }

        public static void GotoLoadingTree()
        {
            LeftNavigation.Reports.Tree.Select1();
        }
        public static void SelectAgreements()
        {
           
            //Driver.Instance.FindElement(By.Id("chkbox_SelectDeselectAgreementTree")).Click();
            var agree = Driver.Instance.FindElements(By.XPath("//span[@class='aciTreeCheck']"));
            agree[0].Click();
            Driver.TurnOnWait();
            var agree1 = Driver.Instance.FindElements(By.XPath("//span[@class='aciTreeCheck']"));
           // agree[-1].Click();
             agree[3].Click();
        }

        public static void SelectAgreements1()
        {
            Driver.TurnOnWait();
            //Driver.Instance.FindElement(By.Id("chkbox_SelectDeselectAgreementTree")).Click();
            var agree = Driver.Instance.FindElements(By.XPath("//span[@class='aciTreeCheck']"));
            agree[0].Click();
            //var agree1 = Driver.Instance.FindElements(By.XPath("//span[@class='aciTreeCheck']"));
            //agree[1].Click();
           // agree[3].Click();
        }
        public static void SelectAgreements2()
        {
            Driver.TurnOnWait();
            //Driver.Instance.FindElement(By.Id("chkbox_SelectDeselectAgreementTree")).Click();
           // var agree = Driver.Instance.FindElements(By.XPath("//span[@class='aciTreeCheck']"));
            //agree[0].Click();
            var agree = Driver.Instance.FindElements(By.XPath("//span[@class='aciTreeCheck']"));
           // agree[-1].Click();
             agree[3].Click();
        }
        public static void AddAgreementstoSearch()
        {
            Driver.Instance.FindElement(By.XPath("//input[@id='btnsubmit']")).Click();
        }

        public static void SelectQuestions()
        {
            Driver.TurnOnWait2();
            Driver.Instance.FindElement(By.Id("chkbox_SelectDeselect")).Click();
            //var isdaque = Driver.Instance.FindElements(By.XPath("//span[@class='aciTreeCheck']"));
            //isdaque[2].Click();
            Driver.Instance.FindElement(By.LinkText("PB")).Click();
            Driver.Instance.FindElement(By.Id("chkbox_SelectDeselect_PB")).Click();
           // var pbque = Driver.Instance.FindElements(By.XPath("//span[@class='aciTreeCheck']"));
           // pbque[10].Click();
            Driver.Instance.FindElement(By.Id("tbReportName")).SendKeys("ISDAPB auto2");
            Driver.Instance.FindElement(By.Id("Submit")).Click();
            Driver.Instance.FindElement(By.XPath("//input[@class='buttonDownLoadReport']")).Click();
            Driver.TurnOnWait3();
            Driver.Instance.FindElement(By.XPath("//a[@id='downloadReport1']")).Click();
            Driver.Instance.FindElement(By.XPath("//a[@id='download62PDF1']")).Click();
            Driver.Instance.FindElement(By.XPath("//a[@id='download63PDF1']")).Click();

            Driver.Instance.FindElement(By.Id("rhome")).Click();
        }
        public static void SelectQuestions1()
        {
            Driver.Instance.FindElement(By.Id("chkbox_SelectDeselect")).Click();
            //var isdaque = Driver.Instance.FindElements(By.XPath("//span[@class='aciTreeCheck']"));
            //isdaque[2].Click();
            //Driver.Instance.FindElement(By.LinkText("PB")).Click();
            //Driver.Instance.FindElement(By.Id("chkbox_SelectDeselect_PB")).Click();
            // var pbque = Driver.Instance.FindElements(By.XPath("//span[@class='aciTreeCheck']"));
            // pbque[10].Click();
            Driver.Instance.FindElement(By.Id("tbReportName")).SendKeys("ISDAPB automation");
            Driver.Instance.FindElement(By.Id("Submit")).Click();
            Driver.Instance.FindElement(By.XPath("//input[@class='buttonDownLoadReport']")).Click();
            Driver.TurnOnWait();
            Driver.Instance.FindElement(By.XPath("//a[@class='buttonDownLoadReport']")).Click();
            Driver.Instance.FindElement(By.Id("rhome")).Click();
        }
        public static void SelectQuestions2()
        {
            //Driver.Instance.FindElement(By.Id("chkbox_SelectDeselect")).Click();
            //var isdaque = Driver.Instance.FindElements(By.XPath("//span[@class='aciTreeCheck']"));
            //isdaque[2].Click();
            //Driver.Instance.FindElement(By.LinkText("PB")).Click();
            Driver.Instance.FindElement(By.Id("chkbox_SelectDeselect_PB")).Click();
            // var pbque = Driver.Instance.FindElements(By.XPath("//span[@class='aciTreeCheck']"));
            // pbque[10].Click();
            Driver.Instance.FindElement(By.Id("tbReportName")).SendKeys("ISDAPB automation");
            Driver.Instance.FindElement(By.Id("Submit")).Click();
            Driver.Instance.FindElement(By.XPath("//input[@class='buttonDownLoadReport']")).Click();
            Driver.TurnOnWait();
            Driver.Instance.FindElement(By.XPath("//a[@class='buttonDownLoadReport']")).Click();
            Driver.Instance.FindElement(By.Id("rhome")).Click();
        }
        public static void GotoCreatePredefinedReport()
        {
            LeftNavigation.Reports.CreatePredefinedReports.Select();
        }

        public static void GotoAnswerISDAProvisions0()
        {
            Driver.Instance.FindElement(By.XPath("//a[@id='ContentPlaceHolder1_gridSavedReports_linkbutton_0']")).Click();
        }
        public static void GotoAnswerISDAProvisions1()
        {
            Driver.Instance.FindElement(By.XPath("//a[@id='ContentPlaceHolder1_gridSavedReports_linkbutton_1']")).Click();
        }
        public static void GotoAnswerISDAProvisions2()
        {
            Driver.Instance.FindElement(By.XPath("//a[@id='ContentPlaceHolder1_gridSavedReports_linkbutton_2']")).Click();
        }
        public static void GotoAnswerISDAProvisions3()
        {
            Driver.Instance.FindElement(By.XPath("//a[@id='ContentPlaceHolder1_gridSavedReports_linkbutton_3']")).Click();
        }
        public static void GotoAnswerISDAProvisions4()
        {
            Driver.Instance.FindElement(By.XPath("//a[@id='ContentPlaceHolder1_gridSavedReports_linkbutton_4']")).Click();
        }
        public static void GotoAnswerISDAProvisions5()
        {
            Driver.Instance.FindElement(By.XPath("//a[@id='ContentPlaceHolder1_gridSavedReports_linkbutton_5']")).Click();
        }
        public static void GotoAnswerISDAProvisions6()
        {
            Driver.Instance.FindElement(By.XPath("//a[@id='ContentPlaceHolder1_gridSavedReports_linkbutton_6']")).Click();
        }
        public static void GotoAnswerISDAProvisions7()
        {
            Driver.Instance.FindElement(By.XPath("//a[@id='ContentPlaceHolder1_gridSavedReports_linkbutton_7']")).Click();
        }
        public static void GotoAnswerISDAProvisions8()
        {
            Driver.Instance.FindElement(By.XPath("//a[@id='ContentPlaceHolder1_gridSavedReports_linkbutton_8']")).Click();
        }
        public static void GotoAnswerISDAProvisions9()
        {
            Driver.Instance.FindElement(By.XPath("//a[@id='ContentPlaceHolder1_gridSavedReports_linkbutton_9']")).Click();
        }
        public static void GotoAnswerISDAProvisions10()
        {
            Driver.Instance.FindElement(By.XPath("//a[@id='ContentPlaceHolder1_gridSavedReports_linkbutton_10']")).Click();
        }
        public static void GotoAnswerISDAProvisions11()
        {
            Driver.Instance.FindElement(By.XPath("//a[@id='ContentPlaceHolder1_gridSavedReports_linkbutton_11']")).Click();
        }
        public static void GotoAnswerISDAProvisions12()
        {
            Driver.Instance.FindElement(By.XPath("//a[@id='ContentPlaceHolder1_gridSavedReports_linkbutton_12']")).Click();
        }
        public static void GotoAnswerISDAProvisions13()
        {
            Driver.Instance.FindElement(By.XPath("//a[@id='ContentPlaceHolder1_gridSavedReports_linkbutton_13']")).Click();
        }
        public static void GotoAnswerISDAProvisions14()
        {
            Driver.Instance.FindElement(By.XPath("//a[@id='ContentPlaceHolder1_gridSavedReports_linkbutton_14']")).Click();
        }
        public static void GotoAnswerISDAProvisions15()
        {
            Driver.Instance.FindElement(By.XPath("//a[@id='ContentPlaceHolder1_gridSavedReports_linkbutton_15']")).Click();
        }
        public static void GotoAnswerISDAProvisions16()
        {
            Driver.Instance.FindElement(By.XPath("//a[@id='ContentPlaceHolder1_gridSavedReports_linkbutton_16']")).Click();
        }

        //ISDA pre defined Reports
        public static void GotoSelectAgreements()
        {
            SelectElement dropdown1 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddAgreementStyle")));
            dropdown1.SelectByValue("All types");
            SelectElement dropdown2 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlClientEntities")));
            dropdown2.SelectByValue("All Client Entities");
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_cbIdentiDocuments_0")).Click();
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_btngo")).Click();
            var selectagreements = Driver.Instance.FindElements(By.XPath("//span[@class='aciTreeCheck']"));
            selectagreements[1].Click();
            Driver.Instance.FindElement(By.Id("btnSubmitAG")).Click();
            Driver.Instance.FindElement(By.XPath("//input[@class='buttonDownLoadReport']")).Click();
            Driver.TurnOnWait1();
            Driver.Instance.FindElement(By.XPath("//a[@class='buttonDownLoadReport']")).Click();
            Driver.TurnOnWait1();
            Driver.Instance.FindElement(By.XPath("//a[@id='rhome']")).Click();
        }
        public static void GotoSelectAgreements1()
        {
            SelectElement dropdown1 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddAgreementStyle")));
            dropdown1.SelectByValue("All types");
            SelectElement dropdown2 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlClientEntities")));
            dropdown2.SelectByValue("All Client Entities");
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_cbIdentiDocuments_1")).Click();
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_btngo")).Click();
            var selectagreements = Driver.Instance.FindElements(By.XPath("//span[@class='aciTreeCheck']"));
            selectagreements[1].Click();
            Driver.Instance.FindElement(By.Id("btnSubmitAG")).Click();
            Driver.Instance.FindElement(By.XPath("//input[@class='buttonDownLoadReport']")).Click();
            Driver.TurnOnWait2();
            Driver.Instance.FindElement(By.XPath("//a[@id='downloadReport']")).Click();
            Driver.TurnOnWait1();
            Driver.Instance.FindElement(By.XPath("//a[@id='rhome']")).Click();
        }

        public static void GotoPBPredefinedReport()
        {
            SelectElement dropdown1 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_dllpredefined")));
            dropdown1.SelectByValue("9");
        }

        public static void SelectProvision0()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_0")).Click();
        }
        public static void SelectProvision1()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_1")).Click();
        }
        public static void SelectProvision2()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_2")).Click();
        }
        public static void SelectProvision3()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_3")).Click();
        }
        public static void SelectProvision4()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_4")).Click();
        }
        public static void SelectProvision5()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_5")).Click();
        }
        public static void SelectProvision6()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_6")).Click();
        }
        public static void SelectProvision7()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_7")).Click();
        }
        public static void SelectProvision8()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_8")).Click();
        }
        public static void SelectProvision9()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_9")).Click();
        }
        public static void SelectProvision10()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_10")).Click();
        }
        public static void SelectProvision11()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_11")).Click();
        }
        public static void SelectProvision12()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_12")).Click();
        }
        public static void SelectProvision13()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_13")).Click();
        }
        public static void SelectProvision14()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_14")).Click();
        }
        public static void SelectProvision15()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_15")).Click();
        }
        public static void SelectProvision16()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_16")).Click();
        }
        public static void SelectProvision17()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_17")).Click();
        }
        public static void SelectProvision18()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_18")).Click();
        }
        public static void SelectProvision19()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_19")).Click();
        }
        public static void SelectProvision20()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_20")).Click();
        }
        public static void SelectProvision21()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_21")).Click();
        }
        public static void SelectProvision22()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_22")).Click();
        }
        public static void SelectProvision23()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_23")).Click();
        }
        public static void SelectProvision24()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_24")).Click();
        }
        public static void SelectProvision25()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_25")).Click();
        }
        public static void SelectProvision26()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_26")).Click();
        }
        public static void SelectProvision27()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_27")).Click();
        }
        public static void SelectProvision28()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_28")).Click();
        }
        public static void SelectProvision29()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_29")).Click();
        }
        public static void SelectProvision30()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_30")).Click();
        }
        public static void SelectProvision31()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_31")).Click();
        }
        public static void SelectProvision32()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_32")).Click();
        }
        public static void SelectProvision33()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_33")).Click();
        }
        public static void SelectProvision34()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_34")).Click();
        }
        public static void SelectProvision35()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_35")).Click();
        }
        public static void SelectProvision36()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_36")).Click();
        }
        public static void SelectProvision37()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_37")).Click();
        }
        public static void SelectProvision38()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_38")).Click();
        }
        public static void SelectProvision39()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_39")).Click();
        }
        public static void SelectProvision40()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_40")).Click();
        }
        public static void SelectProvision41()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_41")).Click();
        }
        public static void SelectProvision42()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_42")).Click();
        }
        public static void SelectProvision43()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_43")).Click();
        }
        public static void SelectProvision44()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_44")).Click();
        }
        public static void SelectProvision45()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_45")).Click();
        }
        public static void SelectProvision46()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_46")).Click();
        }
        public static void SelectProvision47()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_47")).Click();
        }
        public static void SelectProvision48()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_48")).Click();
        }
        public static void SelectProvision49()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_49")).Click();
        }
        public static void SelectProvision50()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_50")).Click();
        }
        public static void SelectProvision51()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_51")).Click();
        }
        public static void SelectProvision52()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_52")).Click();
        }
        public static void SelectProvision53()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_53")).Click();
        }
        public static void SelectProvision54()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_54")).Click();
        }
        public static void SelectProvision55()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_55")).Click();
        }
        public static void SelectProvision56()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_56")).Click();
        }
        public static void SelectProvision57()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_57")).Click();
        }
        public static void SelectProvision58()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_58")).Click();
        }
        public static void SelectProvision59()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_59")).Click();
        }
        public static void SelectProvision60()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_60")).Click();
        }
        public static void SelectProvision61()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_61")).Click();
        }
        public static void SelectProvision62()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_62")).Click();
        }
        public static void SelectProvision63()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_63")).Click();
        }
        public static void SelectProvision64()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_64")).Click();
        }
        public static void SelectProvision65()
        {
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_gridSavedReports_linkbutton_65")).Click();
        }
        //PB Pre-defined Reports
        public static void GetAgreements()
        {
            SelectElement dropdown2 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddAgreementStyle")));
            dropdown2.SelectByValue("1");
            SelectElement dropdown3 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlClientEntities")));
            dropdown3.SelectByValue("5");
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_cbIdentiDocuments_1")).Click();
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_btngo")).Click();
            var select = Driver.Instance.FindElements(By.XPath("//span[@class='aciTreePush']"));
            select[1].Click();
            var selectagreements = Driver.Instance.FindElements(By.XPath("//span[@class='aciTreeCheck']"));
            selectagreements[5].Click();
            Driver.Instance.FindElement(By.Id("SaveSubmitAgreements")).Click();
            Driver.Instance.FindElement(By.XPath("//input[@class='buttonDownLoadReport']")).Click();
            Driver.TurnOnWait1();
            Driver.Instance.FindElement(By.XPath("//a[@class='buttonDownLoadReport']")).Click();
            Driver.TurnOnWait1();
            Driver.Instance.FindElement(By.XPath("//a[@id='rhome']")).Click();
        }
        //PB Predefined Reports PDF
            public static void GetAgreements1()
        {
            SelectElement dropdown2 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddAgreementStyle")));
            dropdown2.SelectByValue("1");
            SelectElement dropdown3 = new SelectElement(Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_ddlClientEntities")));
            dropdown3.SelectByValue("5");
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_cbIdentiDocuments_1")).Click();
            Driver.Instance.FindElement(By.Id("ContentPlaceHolder1_btngo")).Click();
            var select = Driver.Instance.FindElements(By.XPath("//span[@class='aciTreePush']"));
            select[1].Click();
            var selectagreements = Driver.Instance.FindElements(By.XPath("//span[@class='aciTreeCheck']"));
            selectagreements[5].Click();
            Driver.Instance.FindElement(By.Id("SaveSubmitAgreements")).Click();
            Driver.Instance.FindElement(By.XPath("//input[@class='buttonDownLoadReport']")).Click();
            Driver.TurnOnWait1();
            Driver.Instance.FindElement(By.XPath("//a[@id='download113PDF1']")).Click();
            Driver.TurnOnWait1();
            Driver.Instance.FindElement(By.XPath("//a[@id='rhome']")).Click();
        }
      
        }
    }

