using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public class KidneyRARPage : BaseTestPage
    {
        public KidneyRARPage(TestingBrowser browser) : base(browser)
        { }

        public void CheckAgreement()
        {
            RARAgreement_Disclaimer_Checkbox.Click();
        }

        public void ClickStartNow()
        {
            WaitElementAvailable("RARAgreement_StartNow_Button");
            RARAgreement_StartNow_Button.Click();
            browser.Driver.Url = MCIQ_Constants.PageUrl_Kidney_RAR;
        }

        public bool Is3Sections()
        {
            //TODO: do it later
            return true;
        }

        public void Question_KdnyPersHist_Answer(YesNoUnknow v)
        {
            switch (v)
            {
                case YesNoUnknow.Yes:
                    KidneyRAR_KdnyPersHist_RadioButton_Yes.Click();
                    break;
                case YesNoUnknow.No:
                    KidneyRAR_KdnyPersHist_RadioButton_No.Click();
                    break;
                case YesNoUnknow.Unknow:
                    break;
            }  
        }

        public void Question_KdnySex_Answer(Gender gender)
        {
            switch (gender) {
                case Gender.Female:
                    //KidneyRAR_KdnySex_RadioButton_Male.Clear();
                    KidneyRAR_KdnySex_RadioButton_Female.Click();                    
                    break;
                case Gender.Male:
                    //KidneyRAR_KdnySex_RadioButton_Female.Clear();
                    KidneyRAR_KdnySex_RadioButton_Male.Click();
                    break;
                case Gender.Unknow:
                    break;
                    
            }
        }

        public bool IsPreviousButtonEnabled()
        {
            return !RAR_PreviousSection.GetAttribute("class").ToLower().Contains("disabled");
        }

        public bool IsNextButtonEnabled()
        {
            return !RAR_NextSection.GetAttribute("class").ToLower().Contains("disabled");
        }

        public bool IsAtRiskLevel(string v)
        {
            try
            {
                browser.Driver.FindElement(By.Id("riskText")).FindElement(By.XPath($".//span[text()='{v}']"));
                return true;
            }
            catch {
                return false;
            }            
        }

        public void Question_KdnyHT_Answer(YesNoUnknow v)
        {
            WaitElementClickable("KidneyRAR_KdnyHT_Radiobutton_UnKnow");
            switch (v)
            {
                case YesNoUnknow.Yes:
                    KidneyRAR_KdnyHT_Radiobutton_Yes.Click();
                    break;
                case YesNoUnknow.No:
                    KidneyRAR_KdnyHT_Radiobutton_No.Click();
                    break;
                case YesNoUnknow.Unknow:
                    KidneyRAR_KdnyHT_Radiobutton_UnKnow.Click();
                    break;
            }
        }

        public void Question_KdnySmoking_Answer(SmokingHistory v)
        {
            switch (v)
            {
                case SmokingHistory.Yes:
                    KidneyRAR_KdnySmoking_Radiobutton_Yes.Click();
                    break;
                case SmokingHistory.No:
                    KidneyRAR_KdnySmoking_Radiobutton_No.Click();
                    break;
                case SmokingHistory.Iutsbiq:
                    KidneyRAR_KdnySmoking_Radiobutton_Quit.Click();
                    break;
                case SmokingHistory.Unknow:
                    break;
            }
        }

        public void ClickNext(bool toNewUrl, string nextPageUrl)
        {
            WaitElementClickable("RAR_NextSection");
            RAR_NextSection.Click();
            if (toNewUrl) browser.Driver.Url = nextPageUrl;
        }

        public void ClickPrevious(bool toNewUrl, string nextPageUrl)
        {
            WaitElementClickable("RAR_PreviousSection");
            RAR_PreviousSection.Click();
            if (toNewUrl) browser.Driver.Url = nextPageUrl;
        }

        public void ClickGetResult() {
            ClickNext(true, MCIQ_Constants.PageUrl_Kidney_RAR_Result);
        }

        public void ClickSavePDF()
        {
            WaitElementAvailable("RAR_SavePDF");
            RAR_SavePDF.Click();
        }

        public void Question_kdnyAge_Answer(int age)
        {
           // KidneyRAR_KdnyAge_Textbox.Clear();
            KidneyRAR_KdnyAge_Textbox.SendKeys(age.ToString());
        }

        public void Question_KdnyHeight(ImperialOrMetric imperialOrMetric, string height1, string height2= "")
        {
            switch (imperialOrMetric)
            {
                case ImperialOrMetric.Imperial:
                    KidneyRAR_KdnyHeight_RadioButton_Imperial.Click();
                    SelectElement feetDDL = new SelectElement( KidneyRAR_KdnyHeight_DropdownList_Imperial_Feet );
                    feetDDL.SelectByText(height1);
                    SelectElement inchesDDL = new SelectElement(KidneyRAR_KdnyHeight_DropdownList_Imperial_Inches);
                    inchesDDL.SelectByText(height2);
                    break;
                case ImperialOrMetric.Metric:
                    KidneyRAR_KdnyHeight_RadioButton_Metric.Click();
                    SelectElement cmsDDL = new SelectElement(KidneyRAR_KdnyHeight_DropdownList_Metric);
                    cmsDDL.SelectByText(height1);
                    break;
            }
        }
        public void Question_KdnyWeight(int weight, WeightUnit wu)
        {
            switch (wu)
            {
                case WeightUnit.lb:
                    KidneyRAR_KdnyWeight_Radiobutton_lb.Click();
                    break;
                case WeightUnit.kg:
                    KidneyRAR_KdnyWeight_Radiobutton_kg.Click();
                    break;
            }

            //KidneyRAR_KdnyWeight_Textbox.Clear();
            KidneyRAR_KdnyWeight_Textbox.SendKeys(weight.ToString());
        }

        public void Question_KdnySmokingQt_Answer(SmokingQt smokeQt)
        {
            WaitElementClickable("KidneyRAR_KdnyQt_Radiobutton_Morethan25");
            switch (smokeQt) {
                case SmokingQt.Fof:
                    KidneyRAR_KdnyQt_Radiobutton_14orFewer.Click();
                    break;
                case SmokingQt.Bfat:
                    KidneyRAR_KdnyQt_Radiobutton_Bewteem15And25.Click();
                    break;
                case SmokingQt.Mtt:
                    KidneyRAR_KdnyQt_Radiobutton_Morethan25.Click();
                    break;
                case SmokingQt.Unknow:
                    KidneyRAR_KdnyQt_Radiobutton_14orFewer.Clear();
                    KidneyRAR_KdnyQt_Radiobutton_Bewteem15And25.Clear();
                    KidneyRAR_KdnyQt_Radiobutton_Morethan25.Clear();
                    break;
            }
        }

        public void Question_KdnyFamHist_Answer(YesNoUnknow v)
        {
            switch (v)
            {
                case YesNoUnknow.Yes:
                    KidneyRAR_KdnyFamHist_RadioButton_Yes.Click();
                    break;
                case YesNoUnknow.No:
                    KidneyRAR_KdnyFamHist_RadioButton_No.Click();
                    break;
                case YesNoUnknow.Unknow:
                    KidneyRAR_KdnyFamHist_RadioButton_UnKnow.Click();
                    break;
            }   
        }
    }
}
