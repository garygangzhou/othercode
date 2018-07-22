using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LoadFile {
    class Program {
        static void Main(string[] args) {

            string postURL = @"http://localhost/ApiS/api/File/PostFile1";

            string fn = @"C:\Z_Gary\TEMP\License.txt";

            using (var webClient = new WebClient()) {

                byte[] response = webClient.UploadFile(postURL, "POST", fn);
                string res = Encoding.ASCII.GetString(response);

                System.Diagnostics.Debug.WriteLine(res);
            }
        }
    }
}
