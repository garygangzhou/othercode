
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SWH = SeleniumExtras.WaitHelpers;
using System;
using System.IO;
using System.Reflection;

namespace DSPUITestFramework
{
    public partial class TestPageBase 
    {
        public Browser Browser { get; internal set; }

        /// <summary>
        /// page title
        /// </summary>
        public string Title {
            get
            {
                return Browser.Title;
            }
        }       

        /// <summary>
        /// check page title
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public bool IsAtPageTitle(string title)
        {
            return Browser.Title == title;
        }

        /// <summary>
        /// take screenshot
        /// </summary>
        /// <param name="path_folder">folder where screen being kept</param>
        /// <param name="filenameprefix">file name prefix</param>
        public void TakeScreenshot(string path_folder, string filenameprefix) {
            //prepare folder            
            if (!Directory.Exists(path_folder)) Directory.CreateDirectory(path_folder);

            string fn = $"{filenameprefix}-{DateTime.Now.ToString("yyyyMMdd-HHmmss")}.jpg";
            string fullpath = Path.Combine(path_folder, fn);

            Screenshot screen = ((ITakesScreenshot)Browser.Driver).GetScreenshot();
            screen.SaveAsFile(fullpath);
        }      

        /// <summary>
        /// return until element is available, or timeout in 10 seconds
        /// </summary>
        /// <param name="element">property name in TestPageBase_UIElements</param>
        public void WaitElementAvailable(string element) {
            //element is property name in TestPageBase_UIElements
            PropertyInfo eleProp = this.GetType().GetProperty(element);
            WebDriverWait wait = new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(10));
            wait.Until(d =>
            {
                //get property value
                IWebElement ob = eleProp.GetValue(this) as IWebElement; 
                return ob != null && !ob.Size.IsEmpty;
            });
        }

        /// <summary>
        /// return until drop down being populated or time out
        /// </summary>
        /// <param name="element"></param>
        public void WaitDropDownOptionBeingPopulated(string element) {
            //drop down is available
            WaitElementAvailable(element);

            //element is property name in TestPageBase_UIElements
            PropertyInfo eleProp = this.GetType().GetProperty(element);
            IWebElement ddl = eleProp.GetValue(this) as IWebElement;
            SelectElement se = new SelectElement(ddl);
            WebDriverWait wait = new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(10));
            wait.Until(d =>
            {
                return se.Options.Count > 0;
            });
        }

        public bool IsAlertPresent() {
            bool foundAlert = false;
            WebDriverWait wait = new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(3));
            try
            {
                wait.Until(d => 
                    {
                        return SWH.ExpectedConditions.AlertIsPresent();
                    }
                );
                foundAlert = true;
            }
            catch (TimeoutException )
            {
                foundAlert = false;
            }
            return foundAlert;
        }

        public void AcceptAlert(bool accept) {
            if (IsAlertPresent()) {
                if (accept)
                    Browser.Driver.SwitchTo().Alert().Accept();
                else
                    Browser.Driver.SwitchTo().Alert().Dismiss();
            }
        }
    }
}
