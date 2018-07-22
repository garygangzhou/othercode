using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace TestFramework
{
    public enum Browser
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

    public enum BrowserWindowSize {
        Maximium,
        Desktop_1524x768,
        Desktop_1300x2000,
        Desktop_1024x768,
        DesktopNarrow_600x700
    }

    public class TestingBrowser
    {
        private readonly IWebDriver webDriver;
        public TestingBrowser(Browser browser, BrowserWindowSize windowSize) {
            switch (browser)
            {
                case Browser.Firefox:
                    webDriver = new FirefoxDriver();
                    break;
                case Browser.Chrome:
                    webDriver = new ChromeDriver();
                    break;
                case Browser.IE:
                    webDriver = new OpenQA.Selenium.IE.InternetExplorerDriver();
                    break;
                default:
                    throw new DriverServiceNotFoundException($"{browser.ToString()} not supported in this testing suite");

            }

            if (windowSize == BrowserWindowSize.Maximium)
                webDriver.Manage().Window.Maximize();
            else {
                //browser window size format:  whatevername_widthxheight
                string[] browserSize = windowSize.ToString().Split('_')[1].Split('x');
                webDriver.Manage().Window.Size = new System.Drawing.Size(int.Parse(browserSize[0]), int.Parse(browserSize[1]));

            }            
            //switch (windowSize)
            //{
            //    case BrowserWindowSize.Desktop_1524x768:
            //        webDriver.Manage().Window.Size = new System.Drawing.Size(1524, 768);
            //        break;
            //    case BrowserWindowSize.Desktop_Narrow_968x788:
            //        webDriver.Manage().Window.Size = new System.Drawing.Size(968, 768);
            //        break;
            //    case BrowserWindowSize.Desktop_1300x2000:
            //        webDriver.Manage().Window.Size = new System.Drawing.Size(1300, 2000);
            //        break;
            //}
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

        public void Close()
        {         
            webDriver.Quit(); 
        }
    }
}