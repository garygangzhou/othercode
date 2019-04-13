using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DSPUITestFramework
{
    public class SchedulePage : TestPageBase
    {
        public bool VerifySubmissionLink()
        {
            return Link_Submission != null && Link_Submission.Text != null;
        }

        public void ChooseCategory(string categoryText)
        {
            WaitDropDownOptionBeingPopulated("Schedule_DropDown_Category");
            SelectElement se = new SelectElement(Schedule_DropDown_Category);
            se.SelectByText(categoryText);            
        }

        public List<string> AvailablePrograms() {
            WaitProgressMessageDispear();
            SelectElement se = new SelectElement(Schedule_DropDown_Program);
            return se.Options.Select(x => x.Text).ToList();
        }

        public void ChooseProgram(string programText)
        {
            WaitProgressMessageDispear();
            SelectElement se = new SelectElement(Schedule_DropDown_Program);
            se.SelectByText(programText);
        }

        public void ChooseEnable(string text)
        {
            WaitDropDownOptionBeingPopulated("Schedule_DropDown_EnableDisable");
            SelectElement se = new SelectElement(Schedule_DropDown_EnableDisable);
            se.SelectByText(text);
        }

        public void SaveChange()
        {
            Schedule_Button_SaveSchedule.Click();
        }

        public bool VeirfyEnableProgramMessage(string expectedmessage)
        {            
            return Schedule_Div_MessageContainer.Text.Equals(expectedmessage);
        }

        public void ChooseSubmissionPeriod(string submissionperiod)
        {
            WaitProgressMessageDispear();
            SelectElement se = new SelectElement(Schedule_DropDown_SubmissionPeriod);
            se.SelectByText(submissionperiod);
        }

        public void ChooseSite(string siteNbr)
        {
            WaitProgressMessageDispear();
            SelectElement se = new SelectElement(Schedule_DropDown_Site);
            se.SelectByText(siteNbr);
        }

        public void SetEffectiveDate(string datestr)
        {
            Schedule_Text_EffectiveDate.Clear();
            Schedule_Text_EffectiveDate.SendKeys(datestr);
        }

        public void SetDaysEffective(int nbrDays)
        {
            Schedule_Text_NbrOfDaysEffective.Clear();
            Schedule_Text_NbrOfDaysEffective.SendKeys(nbrDays.ToString());
        }

        public void ClickSubmissionLink()
        {
            Link_Submission.Click();
        }

        private void WaitProgressMessageDispear() {
            WebDriverWait wait = new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(10));
            wait.Until(d => {
                return !Schedule_Div_ProcessMessageBar.Displayed;
            });
        }
    }
}
