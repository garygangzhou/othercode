using DSPUITestFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DSPUITests
{
    [TestClass]
    public class ScheduleTests
    {
        readonly string pagetitle = "Submission Schedule Editor - CCO Data Submissioin Portal";
        [TestMethod]
        public void SchedulePage_load()
        {
            using (Browser br = new Browser(BrowserType.Chrome, BrowserSize.Desktop_1350x900))
            {
                br.Goto(Helper.FullUrl(@"/Schedule"));
                SchedulePage sp = br.SetCurrentPageHandler(new SchedulePage());
                
                sp.TakeScreenshot(Helper.Path_Screenshot, "DSP_Schedule_chrome");
                Assert.IsTrue(sp.IsAtPageTitle(pagetitle), "Page tile is wrong, or not correct page");
            }
        }

        [TestMethod]
        public void EnableGIENDOSchedule() {
            using (Browser br = new Browser(BrowserType.Chrome, BrowserSize.Desktop_1350x900))
            {
                br.Goto(Helper.FullUrl(@"/Schedule"));
                SchedulePage sp = br.SetCurrentPageHandler(new SchedulePage());
                
                Assert.IsTrue(sp.IsAtPageTitle(pagetitle));
                Assert.IsTrue(sp.VerifySubmissionLink());

                //disable
                sp.ChooseCategory(@"Enable/Disable Submission Schedule (per Program)");               
                sp.ChooseProgram(@"GI Endoscopy");
                sp.ChooseEnable(@"Disable");
                sp.SaveChange();

                Thread.Sleep(2000);
                Assert.IsTrue(sp.VeirfyEnableProgramMessage("Submission Schedule for 'GI Endoscopy' has been Disabled successfully"), "Disable schedule failed or message is wrong");

                //enable
                sp.ChooseEnable(@"Enable");
                sp.SaveChange();

                Thread.Sleep(2000);
                Assert.IsTrue(sp.VeirfyEnableProgramMessage("Submission Schedule for 'GI Endoscopy' has been Enabled successfully"), "Enable schedule failed or message is wrong");
            }
        }

        [TestMethod]
        public void EnableAllPrograms() {
            using (Browser br = new Browser(BrowserType.Chrome, BrowserSize.Desktop_1024x768)) {
                br.Goto(Helper.FullUrl(@"/Schedule"));
                SchedulePage sp = br.SetCurrentPageHandler(new SchedulePage());

                sp.ChooseCategory(@"Enable/Disable Submission Schedule (per Program)");
                foreach (string program in sp.AvailablePrograms()) {
                    sp.ChooseProgram(program);
                    Thread.Sleep(500);
                    sp.ChooseEnable(@"Enable");
                    sp.SaveChange();
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
