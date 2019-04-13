using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPUITestFramework
{
    public class SubmissionPage : TestPageBase
    {
        public bool Verify3Links()
        {
            return Link_Reports.Text != null &&
                Link_Documents.Text != null &&
                Link_ScheduleEditor.Text != null;
        }

        public void ChooseFile(string filename)
        {
            Submission_Input_SelectFile.SendKeys(filename);
        }

        public void Submit()
        {
            Submission_Button_Submit.Click();
        }

        public bool VerifyErrorMessage(string message)
        {
            WaitElementAvailable("Submission_MessageArea");
            string generic_msg = "File upload failed. Please correct file format and re-submit. To see error details, refer to the Report Viewer";
            return Submission_UploadErrorMessages.Contains(generic_msg) && Submission_UploadErrorMessages.Contains(message) ;
        }

        public void ChooseSite(string siteNbr)
        {
            SelectElement se = new SelectElement(Submission_Dropdown_SiteFacility);
            se.SelectByText(siteNbr);
        }

        public void ChooseProgram(string program)
        {
            SelectElement se = new SelectElement(Submission_Dropdown_Program);
            se.SelectByText(program);
        }

        public void ChooseSubmissionPeriod(string period)
        {
            SelectElement se = new SelectElement(Submission_Dropdown_SubmissionPeriod);
            se.SelectByText(period);
        }

        public bool VerifyWarningMessage(string message)
        {
            WaitElementAvailable("Submission_MessageArea");
            return Submission_UploadWarningMessages.Contains(message);
        }
    }
}
