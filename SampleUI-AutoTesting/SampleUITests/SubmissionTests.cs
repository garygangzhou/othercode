using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSPUITestFramework;
using OpenQA.Selenium.Remote;
using System.Collections.Generic;
using System.Threading;

namespace DSPUITests
{
    [TestClass]
    public class SubmissionTests
    {
        [TestMethod]
        public void Load_SubmissionPage()
        {
            using (Browser br = new Browser(BrowserType.Chrome, BrowserSize.Desktop_1350x900)) {
                br.Goto(Helper.FullUrl(@"/"));
                SubmissionPage sp = br.SetCurrentPageHandler(new SubmissionPage());                

                Assert.IsTrue(sp.IsAtPageTitle("Submission - CCO Data Submissioin Portal"));
                Assert.IsTrue(sp.Verify3Links(), "Reports, Documents, Schedule editor links are wrong");
            }
        }

        // https://sqa.stackexchange.com/questions/2277/using-selenium-webdriver-with-windows-authentication
        // https://stackoverflow.com/questions/28045870/how-can-i-run-internet-explorer-selenium-tests-as-a-specific-domain-user?rq=1


        [TestMethod]
        public void Load_SubmissionPage_Submit()
        {
            string filename = "AbcdTest_5555_201712.csv";
            using (Browser br = new Browser(BrowserType.Chrome, BrowserSize.Desktop_1350x900))
            {
                br.Goto(Helper.FullUrl(@"/"));
                SubmissionPage sp = br.SetCurrentPageHandler(new SubmissionPage());

                Assert.IsTrue(sp.IsAtPageTitle("Submission - CCO Data Submissioin Portal"));
                Assert.IsTrue(sp.Verify3Links(), "Reports, Documents, Schedule editor links are wrong");

                //submit a file
                sp.ChooseFile(System.IO.Path.Combine(Helper.Path_UploadFile, filename));
                sp.Submit();
               
                Assert.IsTrue(sp.VerifyErrorMessage($"File Error - File(s) [{filename}] is incorrectly named."));
            }
        }

        [TestMethod]
        public void Load_SubmissionPage_SubmitGIENDO()
        {
            string filename = "GI_ENDO_5555_201712.csv";
            string program = "GI Endoscopy";
            string submissionperiod = "2017, December";
            string site_schedulepage = "5555 - CCO Test Site";
            string site_submissionpage = "5555 - CCO Test Site (555 - CCO - Test Facility)";

            using (Browser br = new Browser(BrowserType.Chrome, BrowserSize.Maximize))
            {
                //overwrite schedule
                SchedulePage p = OverrideSchedule(br, program, submissionperiod, site_schedulepage) as SchedulePage;
                p.ClickSubmissionLink();
                Thread.Sleep(1000);
                //submit file
                SubmissionPage sp = SubmitFile(br, filename, program, submissionperiod, site_submissionpage);
                Thread.Sleep(3000);
                Assert.IsTrue(sp.VerifyWarningMessage($"File Warning: [{filename}]: You are seeing this warning message because there are duplicate records (more than one procedure record for the same person on the same day) on the file"));
            }
        }

        private SubmissionPage SubmitFile(Browser br, string filename, string program, string submissionperiod, string site_submissionpage)
        {
            SubmissionPage sp = br.SetCurrentPageHandler(new SubmissionPage());

            sp.ChooseProgram(program);
            Thread.Sleep(2000);
            sp.ChooseSite(site_submissionpage);
            Thread.Sleep(2000);
            sp.ChooseSubmissionPeriod(submissionperiod);
            sp.ChooseFile(System.IO.Path.Combine(Helper.Path_UploadFile, filename));
            sp.Submit();

            Thread.Sleep(1000);

            //it might be an alert
            if (sp.IsAlertPresent())
            {
                //accept alert
                sp.AcceptAlert(true);
            }

            sp.TakeScreenshot(Helper.Path_Screenshot, "DSP_Upload");
            return sp;
        }

        //overwrite schedule
        private TestPageBase OverrideSchedule(Browser br, string program, string submissionperiod, string siteNbr)
        {
            br.Goto(Helper.FullUrl("/Schedule"));
            SchedulePage sp = br.SetCurrentPageHandler(new SchedulePage());
            sp.ChooseCategory("Override Schedule (per Site)");
            Thread.Sleep(500);
            sp.ChooseProgram(program);
            Thread.Sleep(500);
            sp.ChooseSubmissionPeriod(submissionperiod);
            Thread.Sleep(500);
            sp.ChooseSite(siteNbr);
            Thread.Sleep(500);
            sp.SetEffectiveDate(DateTime.Now.ToString("MM/dd/yyyy 00:00"));
            sp.SetDaysEffective(2);
            sp.SaveChange();
            Thread.Sleep(1000);

            sp.TakeScreenshot(Helper.Path_Screenshot, "DSP_Override_Schedule");
            return sp;
        }

    }
}
