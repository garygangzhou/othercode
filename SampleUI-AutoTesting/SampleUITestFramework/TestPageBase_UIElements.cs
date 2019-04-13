using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPUITestFramework
{
    public partial class TestPageBase
    {
        #region buttons/links in common
        //page element in this file
        public IWebElement Link_Reports {
            get {
                return Browser.Driver.FindElement(By.LinkText("Reports"));
            }
        }
        public IWebElement Link_Documents
        {
            get
            {
                return Browser.Driver.FindElement(By.LinkText("Documents"));
            }
        }

        public IWebElement Link_ScheduleEditor {
            get {
                return Browser.Driver.FindElement(By.LinkText("Schedule Editor"));
            }
        }

        public IWebElement Link_Submission
        {
            get
            {
                return Browser.Driver.FindElement(By.LinkText("Submissions"));
            }
        }
        #endregion

        #region Submission page
        public IWebElement Submission_Dropdown_Program
        {
            get
            {
                return Browser.Driver.FindElement(By.Id("submissionclasses"));
            }
        }

        public IWebElement Submission_Dropdown_SiteFacility
        {
            get
            {
                return Browser.Driver.FindElement(By.Id("facilitysites"));
            }
        }

        public IWebElement Submission_Dropdown_SubmissionPeriod
        {
            get
            {
                return Browser.Driver.FindElement(By.Id("submissionperiod"));
            }
        }

        public IWebElement Submission_Dropdown_NoCasesReason
        {
            get
            {
                return Browser.Driver.FindElement(By.Id("nocasesreasons"));
            }
        }

        public IWebElement Submission_CheckBox_NoCases
        {
            get
            {
                return Browser.Driver.FindElement(By.Id("chknocasestosubmit"));
            }
        }

        public IWebElement Submission_Button_Submit {
            get
            {
                return Browser.Driver.FindElement(By.Id("submissionbutton"));
            }
        }
        
        public IWebElement Submission_Input_SelectFile
        {
            get
            {
                return Browser.Driver.FindElement(By.Id("userSelectedFile"));
            }
        }

        public IWebElement Submission_MessageArea {
            get {
                return Browser.Driver.FindElement(By.ClassName("message-area"));
            }
        }

        public List<string> Submission_UploadErrorMessages {
            get
            {
                List<string> msgs = new List<string> ();
                IWebElement msgboard = Browser.Driver.FindElements(By.TagName("fieldset")).First(x => x.GetAttribute("class").Equals("message-area"));

                if (msgboard != null)
                {
                    IWebElement e1 = msgboard.FindElement(By.ClassName("validation-summary-errors"));
                    if (e1 != null) msgs.Add(e1.Text);

                    IWebElement e2 = msgboard.FindElement(By.ClassName("message-error"));
                    if (e2 != null)
                    {
                        List<IWebElement> eles = e2.FindElements(By.TagName("li")).ToList();
                        if (eles != null && eles.Any())
                        {
                            foreach (IWebElement we in eles)
                                msgs.Add(we.Text);
                        }
                    }
                }
                return msgs;
            }
        }

        public List<string> Submission_UploadWarningMessages {
            get {
                List<string> msgs = new List<string>();
                IWebElement msgboard = Browser.Driver.FindElements(By.TagName("fieldset")).First(x => x.GetAttribute("class").Equals("message-area"));

                if (msgboard != null)
                {
                    IWebElement e1 = msgboard.FindElement(By.ClassName("validation-summary-warnings"));
                    if (e1 != null)
                    {
                        List<IWebElement> eles = e1.FindElements(By.TagName("li")).ToList();
                        if (eles != null && eles.Any())
                        {
                            foreach (IWebElement we in eles)
                                msgs.Add(we.Text);
                        }
                    }
                }
                return msgs;
            }
        }
        #endregion

        #region schedule
        public IWebElement Schedule_Div_ProcessMessageBar {
            get {
                return Browser.Driver.FindElement(By.Id("updateProgress"));
            }
        }

        public IWebElement Schedule_DropDown_Category {
            get {
                return Browser.Driver.FindElement(By.Id("editCategory"));
            }
        }

        public IWebElement Schedule_DropDown_Program
        {
            get
            {
                return Browser.Driver.FindElement(By.Id("submissionClass"));
            }
        }

        public IWebElement Schedule_DropDown_SubmissionPeriod
        {
            get
            {
                return Browser.Driver.FindElement(By.Id("reportingperiod"));
            }
        }

        public IWebElement Schedule_DropDown_Site
        {
            get
            {
                return Browser.Driver.FindElement(By.Id("submissionSite"));
            }
        }

        public IWebElement Schedule_Text_EffectiveDate
        {
            get
            {
                return Browser.Driver.FindElement(By.Id("overrideEffectiveDay"));
            }
        }

        public IWebElement Schedule_Text_NbrOfDaysEffective
        {
            get
            {
                return Browser.Driver.FindElement(By.Id("numberOfDaysEffective"));
            }
        }

        public IWebElement Schedule_DropDown_EnableDisable
        {
            get
            {
                return Browser.Driver.FindElement(By.Id("enableSchedule"));
            }
        }

        public IWebElement Schedule_Button_SaveSchedule
        {
            get
            {
                return Browser.Driver.FindElement(By.Id("btnSaveSchedule"));
            }
        }

        public IWebElement Schedule_Div_MessageContainer {
            get
            {
                return Browser.Driver.FindElement(By.Id("divMessageContainer"));
            }
        }

        #endregion
    }    
}
