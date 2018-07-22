using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    //samples from various sources
    public class GoodController : Controller
    {        
        public ActionResult GiveMePlainText()
        {
            return Content($"Here it is {DateTime.Now.ToString ()}", MediaTypeNames.Text.Plain);
        }
        public string GiveMePlainText2() { return "Hello."; }
        public Person GiveMePlainText1() {
            return new Person() { FirstName="given name", LastName="sn" };
        }

        public ActionResult GiveMeJsonText() {
            
            return Json( (new Person() { FirstName = "given name", LastName = "sn" }), 
                JsonRequestBehavior.AllowGet) ;
        }

        public JavaScriptResult SayHello() {
            return JavaScript("alert('Hello, world!');");
        }
        public FilePathResult DownloadFile() {
            string filename = @"C:\Temp\testingoutput.txt.temp.txt";
            return File(filename, "application/text", "text.txt");
        }

        public FileContentResult DownloadReport() {
            //byte[] data = ... // Generate or fetch the file contents somehow
            //return File(data, "application/pdf", "AnnualReport.pdf");
            return null;
        }

        public FileStreamResult ProxyExampleDotCom() {
            WebClient wc = new WebClient();
            Stream stream = wc.OpenRead("http://www.example.com/");
            return File(stream, "text/html");
        }
    }

    public class Person {
        public string FirstName{get;set;}
        public string LastName { get; set; }
        public DateTime BDate { get; set; }
    }
}