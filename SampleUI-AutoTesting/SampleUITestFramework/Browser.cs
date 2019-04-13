using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System;

namespace DSPUITestFramework
{
    public enum BrowserType
    {
        All,
        HtmlUnit,
        IE,
        Edge,
        Firefox,
        Safari,
        Chrome,
        Opera,
        Remote,
        IPhone,
        Android,
        WindowsPhone,
        PhantomJS
    }

    public enum BrowserSize {
        Maximize,
        Desktop_1350x900,       
        Desktop_1024x768,
        DesktopNarrow_600x700
    }

    public class Browser : IDisposable
    {
        private readonly IWebDriver webDriver;

        public Browser(BrowserType browser, BrowserSize windowSize) {
            switch (browser)
            {
                case BrowserType.Firefox:
                    webDriver = new FirefoxDriver();
                    break;
                case BrowserType.Chrome:
                    webDriver = new ChromeDriver();
                    break;
                case BrowserType.IE:
                    webDriver = new OpenQA.Selenium.IE.InternetExplorerDriver();
                    break;
                default:
                    throw new DriverServiceNotFoundException($"{browser.ToString()} not supported in this testing suite");

            }
            
            if (windowSize == BrowserSize.Maximize)
                webDriver.Manage().Window.Maximize();
            else
            {
                //browser window size format:  whatevername_widthxheight
                //example Desktop_1524x768
                string[] browserSize = windowSize.ToString().Split('_')[1].Split('x');
                webDriver.Manage().Window.Size = new System.Drawing.Size(int.Parse(browserSize[0]), int.Parse(browserSize[1]));
            }
        }
      
        public string Title
        {
            get { return webDriver.Title; }
        }

         public IWebDriver Driver
       // public ISearchContext Driver
        {
            get { return webDriver; }
        }

        public void Goto(string url)
        {
            webDriver.Url = url;           
        }

        public T SetCurrentPageHandler<T>(T page) where T: TestPageBase
        {
            page.Browser = this;
            return page;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            webDriver.Quit();
        }
    }
}
