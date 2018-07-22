
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;

namespace TestFramework
{
    public partial class BaseTestPage : IDisposable
    {
        protected TestingBrowser browser;
        protected BaseTestPage(TestingBrowser br)
        {
            this.browser = br;
           
            //SeleniumExtras.PageObjects.PageFactory.InitElements(br.Driver, this);
            //OpenQA.Selenium.Support.PageObjects.PageFactory.InitElements(br.Driver, this);
        }

        public string Title {
            get
            {
                return browser.Title;
            }
        }

        public void GotoPage(string page)
        {
            browser.Goto(page);
        }

        /// <summary>
        /// check page title
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public bool IsAtPageTitle(string title)
        {
            return browser.Title == title;
        }

        public void TakeScreenshot(string filenameprefix) {
            //prepare folder
            string path = System.Configuration.ConfigurationManager.AppSettings["ScreenshotFolder"];
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

            string fn = $"{filenameprefix}-{DateTime.Now.ToString("yyyyMMdd-HHmmss")}.jpg";
            string fullpath = Path.Combine(path, fn);

            Screenshot screen = ((ITakesScreenshot)browser.Driver).GetScreenshot();
            screen.SaveAsFile(fullpath);
        }

        public void Dispose()
        {
            if (browser != null)
            {
                browser.Driver.Close();
                browser.Driver.Quit();
            }
        }

        public void WaitElementAvailable(string element) {
            //element is property name in BaseTestPageUIElements
            PropertyInfo eleProp = this.GetType().GetProperty(element);
            WebDriverWait wait = new WebDriverWait(browser.Driver, TimeSpan.FromSeconds(5));
            wait.Until(d =>
            {
                //get property value
                object ob = eleProp.GetValue(this);              
                return ob != null;
            });
        }

        public void WaitElementClickable(string element) {                       
            PropertyInfo eleProp = this.GetType().GetProperty(element);
            WebDriverWait wait = new WebDriverWait(browser.Driver, TimeSpan.FromSeconds(5));
            wait.Until(d =>
            {                
                //get property value
                object ob = eleProp.GetValue(this);
                if (ob == null) return false;                
                IWebElement we = ob as IWebElement;
                return !we.GetAttribute("class").ToLower().Contains("disabled");                    
            });
        }
    }
}
