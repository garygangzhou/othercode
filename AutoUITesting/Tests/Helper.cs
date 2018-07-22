using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MCIQUITests
{
    public class TestingHelper
    {
        public static string FullUrl(string pageURL) {
            return System.Configuration.ConfigurationManager.AppSettings["BaseUrl"] + pageURL;
        }

        internal static string OutputResult(List<CheckpointResultGroup> overallResults, string folder, string filenameprefix)
        {
            if (overallResults != null)
            {                
                if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);

                string fn = $"{filenameprefix}-{DateTime.Now.ToString("yyyyMMdd-HHmmss")}.txt";
                string fullpath = Path.Combine(folder, fn);
                using (StreamWriter sw = File.CreateText(fullpath))
                {
                    foreach (CheckpointResultGroup ckprg in overallResults)
                    {
                        if (ckprg.GroupResult)
                            sw.WriteLine($"Seq={ckprg.TestSeq}, Result=Pass");
                        else
                        {
                            foreach (CheckpointResult r in ckprg.CheckpointResults)
                            {
                                if (!r.Result) sw.WriteLine($"Seq={ckprg.TestSeq}, Result=Failed, Checkpoint:{r.CheckPoint}, {r.Result}, {r.Message}");
                            }
                        }
                    }
                }
                return fullpath;
            }
            return string.Empty;
        }
    }
    
    public class CheckpointResult
    {
        public string CheckPoint { get; set; } = string.Empty;
        public bool Result { get; set; } = false;
        public string Message { get; set; } = string.Empty;

    }

    public class CheckpointResultGroup
    {
        public int TestSeq { get; set; }
        public List<CheckpointResult> CheckpointResults { get; set; } = new List<CheckpointResult>();
        public bool GroupResult {
            get {
                var failed = CheckpointResults.Where(x => x.Result == false);
                return !failed.Any();
            }
        }
    }
    
}
