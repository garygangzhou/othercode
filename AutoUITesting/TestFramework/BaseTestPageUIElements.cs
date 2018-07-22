using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;

namespace TestFramework
{
    public partial class BaseTestPage
    {
        #region top menu Fields in UI

        //[FindsBy(How = How.LinkText, Using = @"HOME")]
        public IWebElement Topmenu_HOME {
            get {
                return browser.Driver.FindElement(By.LinkText("HOME"));
            }
        }

        //[FindsBy(How = How.LinkText, Using = @"WHAT'S MY RISK?")]
        public IWebElement Topmenu_What_Is_My_Risk
        { 
            get {
                return browser.Driver.FindElement(By.LinkText(@"WHAT'S MY RISK?"));
            }
        }

        //[FindsBy(How = How.LinkText, Using = @"ABOUT My CancerIQ")]
        public IWebElement Topmenu_ABOUT_My_CancerIQ
        {
            get
            {
                return browser.Driver.FindElement(By.LinkText(@"ABOUT My CancerIQ"));
            }
        }

       // [FindsBy(How = How.LinkText, Using = @"ABOUT CANCER RISK")]
        public IWebElement Topmenu_ABOUT_Cancer_Risk
        {
            get
            {
                return browser.Driver.FindElement(By.LinkText(@"ABOUT CANCER RISK"));
            }
        }

        //[FindsBy(How = How.LinkText, Using = @"FOR HEALTHCARE PROVIDERS")]
        public IWebElement Topmenu_For_HealthCare_Providers
        {
            get
            {
                return browser.Driver.FindElement(By.LinkText(@"FOR HEALTHCARE PROVIDERS"));
            }
        }

        #endregion

        #region side menu

        #endregion

        #region RAR Agreement 
        public IWebElement RARAgreement_Disclaimer_Checkbox
        {
            get
            {
                return browser.Driver.FindElement(By.Id("disclaimer"));
            }
        }

        public IWebElement RARAgreement_StartNow_Button
        {
            get
            {
                return browser.Driver.FindElement(By.Id("submit"));
            }
        }

        #endregion

        #region RAR Kidney
        public IWebElement KidneyRAR_KdnyPersHist_RadioButton_No
        {
            get
            {
                return Find_RadiobuttonInDiv("KdnyPersHist", "N");
            }
        }

        public IWebElement KidneyRAR_KdnyPersHist_RadioButton_Yes
        {
            get
            {
                return Find_RadiobuttonInDiv("KdnyPersHist", "Y");
            }
        }

        public IWebElement KidneyRAR_KdnySex_RadioButton_Male
        {
            get
            {
                return Find_RadiobuttonInDiv("SexChoice", "M");
            }
        }

        public IWebElement KidneyRAR_KdnySex_RadioButton_Female
        {
            get
            {
                return Find_RadiobuttonInDiv("SexChoice", "F");
            }
        }

        public IWebElement KidneyRAR_KdnyAge_Textbox
        {
            get {
                IWebElement div = browser.Driver.FindElement(By.Id("KdnyAge"));
                return div.FindElement(By.TagName("input"));
            }
        }

        public IWebElement KidneyRAR_KdnyFamHist_RadioButton_Yes
        {
            get
            {
                return Find_RadiobuttonInDiv("KdnyFamHist", "Y");
            }
        }

        public IWebElement KidneyRAR_KdnyFamHist_RadioButton_No
        {
            get
            {
                return Find_RadiobuttonInDiv("KdnyFamHist", "N"); 
            }
        }
        public IWebElement KidneyRAR_KdnyFamHist_RadioButton_UnKnow
        {
            get
            {
                return Find_RadiobuttonInDiv("KdnyFamHist", "UnKnwn");
            }
        }
      
        public IWebElement KidneyRAR_KdnyHeight_RadioButton_Imperial {
            get
            {
                return Find_RadiobuttonInDiv("KdnyHeight", "in");
            }
        }

        public IWebElement KidneyRAR_KdnyHeight_RadioButton_Metric
        {
            get
            {
                return Find_RadiobuttonInDiv("KdnyHeight", "cm");
            }
        }

        public IWebElement KidneyRAR_KdnyHeight_DropdownList_Metric
        {
            get
            {
                return Find_DropDownListInDiv("KdnyHeight", "metricCM");
            }
        }
        public IWebElement KidneyRAR_KdnyHeight_DropdownList_Imperial_Feet
        {
            get
            {
                return Find_DropDownListInDiv("KdnyHeight", "imperialFeet");
            }
        }
        public IWebElement KidneyRAR_KdnyHeight_DropdownList_Imperial_Inches
        {
            get
            {
                return Find_DropDownListInDiv("KdnyHeight", "imperialInches");
            }
        }
        
        public IWebElement KidneyRAR_KdnyWeight_Radiobutton_lb
        {
            get
            {
                return Find_RadiobuttonInDiv("KdnyWeight", "lb");
            }
        }
        public IWebElement KidneyRAR_KdnyWeight_Radiobutton_kg
        {
            get
            {
                return Find_RadiobuttonInDiv("KdnyWeight", "kg");
            }
        }
        public IWebElement KidneyRAR_KdnyWeight_Textbox
        {
            get
            {
                IWebElement div = browser.Driver.FindElement(By.Id("KdnyWeight"));
                return div.FindElement(By.TagName("input"));
            }
        }
        public IWebElement RAR_NextSection {
            get
            {
                return browser.Driver.FindElement(By.Id("nextSection"));
            }
        }

        public IWebElement RAR_PreviousSection
        {
            get
            {
                return browser.Driver.FindElement(By.Id("prevSection"));
            }
        }

        public IWebElement RAR_SavePDF
        {
            get
            {
                return browser.Driver.FindElement(By.Id("savePdf"));
            }
        }

        public IWebElement KidneyRAR_KdnyHT_Radiobutton_No
        {
            get {
                return Find_RadiobuttonInDiv("KdnyHT", "N");
            }
        }
        public IWebElement KidneyRAR_KdnyHT_Radiobutton_Yes
        {
            get
            {
                return Find_RadiobuttonInDiv("KdnyHT", "Y");
            }
        }
        public IWebElement KidneyRAR_KdnyHT_Radiobutton_UnKnow
        {
            get
            {
                return Find_RadiobuttonInDiv("KdnyHT", "UnKnwn");
            }
        }

        public IWebElement KidneyRAR_KdnySmoking_Radiobutton_Yes
        {
            get
            {
                return Find_RadiobuttonInDiv("KdnySmoking", "Y");
            }
        }
        public IWebElement KidneyRAR_KdnySmoking_Radiobutton_No
        {
            get
            {
                return Find_RadiobuttonInDiv("KdnySmoking", "N");
            }
        }
        public IWebElement KidneyRAR_KdnySmoking_Radiobutton_Quit
        {
            get
            {
                return Find_RadiobuttonInDiv("KdnySmoking", "Iutsbiq");
            }
        }
        public IWebElement KidneyRAR_KdnyQt_Radiobutton_14orFewer
        {
            get
            {
                return Find_RadiobuttonInDiv("KdnySmokeQt", "Fof");
            }
        }
        public IWebElement KidneyRAR_KdnyQt_Radiobutton_Bewteem15And25
        {
            get
            {
                return Find_RadiobuttonInDiv("KdnySmokeQt", "Bfat");
            }
        }
        public IWebElement KidneyRAR_KdnyQt_Radiobutton_Morethan25
        {
            get
            {
                return Find_RadiobuttonInDiv("KdnySmokeQt", "Mtt");
            }
        }
        #endregion


        #region helpers
        private IWebElement Find_RadiobuttonInDiv(string divID, string radio_value)
        {
            IWebElement div = browser.Driver.FindElement(By.Id(divID));
            List<IWebElement> radiobtns = new List<IWebElement>(div.FindElements(By.TagName("input")));
            if (radiobtns.Any()) {
                return radiobtns.First(x => x.GetAttribute("value") == radio_value && x.GetAttribute("type") == "radio");
            }
            return null;
        }

        private IWebElement Find_DropDownListInDiv(string divID, string ddlID)
        {
            IWebElement div = browser.Driver.FindElement(By.Id(divID));
            return div.FindElement(By.Id(ddlID));
        }

        #endregion
    }
}
