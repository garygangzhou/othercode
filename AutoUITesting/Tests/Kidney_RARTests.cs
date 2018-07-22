using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestFramework;

namespace MCIQUITests
{
    [TestClass]
    public class Kidney_RARTests
    {
        [TestMethod]
        public void KidneyRAR()
        {            
            //KidneyRARPage kr = new KidneyRARPage(new TestingBrowser(Browser.Chrome, BrowserWindowSize.DesktopNarrow_968x788));
            using (KidneyRARPage kr = new KidneyRARPage(new TestingBrowser(Browser.Chrome, BrowserWindowSize.Desktop_1300x2000)))
            {
                kr.GotoPage(TestingHelper.FullUrl(MCIQ_Constants.PageUrl_Kidney_RARAgreement));
                kr.CheckAgreement();
                kr.ClickStartNow();

                Assert.IsTrue(kr.IsAtPageTitle(MCIQ_Constants.PageTitle_Kidney_Cancer_Assessment), "Kidney RAR in wrong page");

                //verify there are 3 sections
                Assert.IsTrue(kr.Is3Sections());

                //set answers
                //section 1
                kr.Question_KdnyPersHist_Answer(YesNoUnknow.No);
                kr.Question_KdnySex_Answer(Gender.Male);
                kr.Question_kdnyAge_Answer(56);
                kr.Question_KdnyFamHist_Answer(YesNoUnknow.No);
                //kr.Question_KdnyHeight(ImperialOrMetric.Metric, "180 cm");
                kr.Question_KdnyHeight(ImperialOrMetric.Imperial, "6'", "1\"");
                kr.Question_KdnyWeight(200, WeightUnit.lb);                        

                //Assert.IsTrue(kr.IsNextButtonEnabled(), "section 1 next button not enable");
                //Assert.IsFalse(kr.IsPreviousButtonEnabled(), "section 1 previous button not disable");

                kr.ClickNext(false, "");

                //section 2
                Thread.Sleep(100);
                kr.Question_KdnyHT_Answer(YesNoUnknow.No);               

                //Assert.IsTrue(kr.IsNextButtonEnabled(), "section 2 next button not enable");
                //Assert.IsTrue(kr.IsPreviousButtonEnabled(), "section 2 previous button not enable");
                               
                kr.ClickNext(false, "");
               
                //section 3
                kr.Question_KdnySmoking_Answer(SmokingHistory.No);

                //Assert.IsTrue(kr.IsNextButtonEnabled(), "section 3 next button not enable");
                //Assert.IsTrue(kr.IsPreviousButtonEnabled(), "section 3 previous button not enable");
                
                kr.ClickGetResult();
                kr.TakeScreenshot("Kidney_RARTests_KidneyRAR");
                Assert.IsTrue(kr.IsAtRiskLevel("LOWER THAN AVERAGE"), "Risk level is not correct");

               // kr.ClickSavePDF();
               // Thread.Sleep(3000);                
            }
        }

        [TestMethod]
        public void KidneyReadAnswerFile() {
            //prepare answer file
            RARAnswerFileReader reader = new RARAnswerFileReader();
            List<KidneyRARAnswer> answers = reader.ReadAnswerFile<KidneyRARAnswer>(ConfigurationManager.AppSettings["KidneyQuestionAnswerFile"]);
            List<CheckpointResultGroup> overallResults = new List<CheckpointResultGroup>();

            //loop through answer file
            foreach (KidneyRARAnswer an in answers)
            {
                if (an.Seq_int < 0) continue; //skip any line with negative Seq

                CheckpointResultGroup ckpg = new CheckpointResultGroup();                
                ckpg.TestSeq = an.Seq_int;
                overallResults.Add(ckpg);                

                using (KidneyRARPage kr = new KidneyRARPage(new TestingBrowser(Browser.Chrome, BrowserWindowSize.Desktop_1300x2000)))
                {
                    kr.GotoPage(TestingHelper.FullUrl(MCIQ_Constants.PageUrl_Kidney_RARAgreement));
                    kr.CheckAgreement();
                    kr.ClickStartNow();

                    bool titlechk = kr.IsAtPageTitle(MCIQ_Constants.PageTitle_Kidney_Cancer_Assessment);
                    AddCheckingResult(ckpg, "pagetitle", titlechk, "page title is wrong");

                    if (titlechk)
                    {
                        kr.GotoPage(TestingHelper.FullUrl(MCIQ_Constants.PageUrl_Kidney_RAR));
                        PerformAssessment(kr, an, ckpg);
                    }
                }
                //wait system to clean up resource
                Thread.Sleep(2000);               
            }

            //output a report
            string report = TestingHelper.OutputResult(overallResults, ConfigurationManager.AppSettings["KidneyRARBatchReportFileFolder"], "KidneyRAR");

            Assert.IsFalse(overallResults.Where(x => x.GroupResult == false ).Any(), "There is error on testing, please read testing report " + report);
        }

        private void PerformAssessment(KidneyRARPage kr, KidneyRARAnswer answer, CheckpointResultGroup ckpg)
        {
            try
            {
                //section 1
                kr.Question_KdnyPersHist_Answer(answer.KdnyPersHist_Enum);
                kr.Question_KdnySex_Answer(answer.KdnySex_Enum);
                kr.Question_kdnyAge_Answer(answer.KdnAge_int);
                kr.Question_KdnyFamHist_Answer(answer.KdnyFamHist_Enum);

                if (answer.KdnyHeight_Imperial_bool)
                {
                    kr.Question_KdnyHeight(ImperialOrMetric.Imperial, answer.KdnyHeight_V1, answer.KdnyHeight_V2);
                }
                else if (answer.KdnyHeight_Metric_bool)
                {
                    kr.Question_KdnyHeight(ImperialOrMetric.Metric, answer.KdnyHeight_V1);
                }

                if (answer.KdnyWeightLB_int != 0)
                    kr.Question_KdnyWeight(answer.KdnyWeightLB_int, WeightUnit.lb);
                else if (answer.KdnyWeightKG_int != 0)
                    kr.Question_KdnyWeight(answer.KdnyWeightKG_int, WeightUnit.kg);                

                //verify Next button enabled
                AddCheckingResult(ckpg, "1", kr.IsNextButtonEnabled(), "section 1 next button not enabled");
                AddCheckingResult(ckpg, "2", !kr.IsPreviousButtonEnabled(), "section 1 previous button not disable");
                kr.TakeScreenshot($"KidneyRARBatch_{answer.Seq}_Section1" );

                kr.ClickNext(false, "");
                Thread.Sleep(100);

                //section 2
                kr.Question_KdnyHT_Answer(answer.KdnyHT_Enum);
                
                AddCheckingResult(ckpg, "3", kr.IsNextButtonEnabled(), "section 2 next button not enabled");
                AddCheckingResult(ckpg, "4", kr.IsPreviousButtonEnabled(), "section 2 previous button not enable");
                kr.TakeScreenshot($"KidneyRARBatch_{answer.Seq}_Section2");

                kr.ClickNext(false, "");                

                //section 3
                kr.Question_KdnySmoking_Answer(answer.KdnySmoking_Enum);

                if (answer.KdnySmoking_Enum == SmokingHistory.Yes)
                {
                    kr.Question_KdnySmokingQt_Answer(answer.KdnySmokeQt_Enum);
                }
               
                AddCheckingResult(ckpg, "5", kr.IsNextButtonEnabled(), "section 3 next button not enabled");
                AddCheckingResult(ckpg, "6", kr.IsPreviousButtonEnabled(), "section 3 previous button not enable");
                kr.TakeScreenshot($"KidneyRARBatch_{answer.Seq}_Section3");

                kr.ClickGetResult();
               
                //kr.WaitElementAvailable("RAR_SavePDF");
                kr.TakeScreenshot($"KidneyRARBatch_{answer.Seq}_Report");
                AddCheckingResult(ckpg, "7", kr.IsAtRiskLevel(answer.Result), "Risk level is not correct");
            }
            catch(Exception ex)
            {
                kr.TakeScreenshot($"KidneyRARBatch_{answer.Seq}_OnPageError");
                AddCheckingResult(ckpg, "0000", false, ex.ToString());
            }
        }

        private void AddCheckingResult(CheckpointResultGroup ckpg, string checkpoint_id, bool result, string message)
        {
            ckpg.CheckpointResults.Add(new CheckpointResult
            {
                CheckPoint = checkpoint_id,
                Result = result,
                Message = message
            });           
        }        
    }
}
