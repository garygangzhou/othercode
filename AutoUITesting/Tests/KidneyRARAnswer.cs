using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework;

namespace MCIQUITests
{
    public class RARAnswerFileReader
    {
        //read CSV file
        public List<T> ReadAnswerFile<T>(string filepath) {
            List<T> answers = new List<T>();
            if (!File.Exists(filepath)) return answers;
            using (CsvReader reader = new CsvReader(new StreamReader(filepath, true), true))
            {
                string[] headers = reader.GetFieldHeaders();
                while (reader.ReadNextRecord())
                {                    
                    var answer = (T)Activator.CreateInstance(typeof(T));
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        string fieldname = headers[i];
                        answer.GetType().GetProperty(fieldname).SetValue(answer, reader[i]);
                    }
                    answers.Add(answer);
                }
            }
            return answers;
        }
    }

    public class KidneyRARAnswer
    {
        public string Seq { get; set; }
        public int Seq_int => int.Parse(Seq);
        public string KdnyPersHist { get; set; }
        public YesNoUnknow KdnyPersHist_Enum
        {
            get
            {
                try
                {
                    return (YesNoUnknow)Enum.Parse(typeof(YesNoUnknow), KdnyPersHist);
                }
                catch
                {
                    return YesNoUnknow.Unknow;
                }
            }
        }
        public string KdnySex { get; set; }
        public Gender KdnySex_Enum {
            get {
                try {
                    return (Gender)Enum.Parse(typeof(Gender), KdnySex);
                }
                catch {
                    return Gender.Unknow;
                }
            }
        }
        public string KdnyAge { get; set; }
        public int KdnAge_int => int.Parse(KdnyAge);
        public string KdnyFamHist { get; set; }
        public YesNoUnknow KdnyFamHist_Enum
        {
            get
            {
                try
                {
                    return (YesNoUnknow)Enum.Parse(typeof(YesNoUnknow), KdnyFamHist);
                }
                catch
                {
                    return YesNoUnknow.Unknow;
                }
            }
        }
        public string KdnyHeight_Imperial { get; set; }
        public bool KdnyHeight_Imperial_bool => bool.Parse(KdnyHeight_Imperial);
        public string KdnyHeight_Metric { get; set; }
        public bool KdnyHeight_Metric_bool => bool.Parse(KdnyHeight_Metric);
        public string KdnyHeight_V1 { get; set; }
        public string KdnyHeight_V2 { get; set; }
        public string KdnyWeightLB { get; set; }
        public int KdnyWeightLB_int
        {
            get
            {
                if (string.IsNullOrEmpty(KdnyWeightLB))
                    return 0;
                return int.Parse(KdnyWeightLB.Substring(0, KdnyWeightLB.Length - 2));
            }
        }
        public string KdnyWeightKG { get; set; }
        public int KdnyWeightKG_int
        {
            get
            {
                if (string.IsNullOrEmpty(KdnyWeightKG))
                    return 0;
                return int.Parse(KdnyWeightKG.Substring(0, KdnyWeightKG.Length - 2));
            }
        }
        public string KdnyHT { get; set; }
        public YesNoUnknow KdnyHT_Enum
        {
            get
            {
                try {
                    return (YesNoUnknow)Enum.Parse(typeof(YesNoUnknow), KdnyHT);
                }
                catch {
                    return YesNoUnknow.Unknow;
                }
            }
        }
        public string KdnySmoking { get; set; }
        public SmokingHistory KdnySmoking_Enum
        {
            get
            {
                try {
                    return (SmokingHistory)Enum.Parse(typeof(SmokingHistory), KdnySmoking);
                }
                catch {
                    return SmokingHistory.Unknow;
                }
            }
        }
        public string KdnySmokeQt { get; set; }
        public SmokingQt KdnySmokeQt_Enum {
        get {
                try {
                    return (SmokingQt)Enum.Parse(typeof(SmokingQt), KdnySmokeQt);
                }
                catch {
                    return SmokingQt.Unknow;
                }
            }
        }
        public string Result { get; set; }        
    }
}
