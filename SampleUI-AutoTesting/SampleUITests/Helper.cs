using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPUITests
{
    public class Helper
    {
       //utility class should not have constructor
        private Helper() { }

        public readonly static string BaseSiteUrl = System.Configuration.ConfigurationManager.AppSettings["BaseUrl"];
        public readonly static string Path_Screenshot = System.Configuration.ConfigurationManager.AppSettings["ScreenshotFolder"];
        public readonly static string Path_UploadFile = System.Configuration.ConfigurationManager.AppSettings["UploadFilesFolder"];

        public static string FullUrl(string path) {
            return  BaseSiteUrl + path;
        }
      
    }
}
