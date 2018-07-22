using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;

namespace MCIQUITests
{
    [TestClass]
    public class HomePageTests
    {
        [TestMethod]
        public void HomePage_Load() {
            using (HomePage homepage = new HomePage(new TestingBrowser(Browser.Chrome, BrowserWindowSize.Maximium)))
            {
                homepage.GotoPage(TestingHelper.FullUrl( MCIQ_Constants.PageUrl_Home));
                homepage.TakeScreenshot("HomePage_Load");
                Assert.IsTrue(homepage.Title.Equals(MCIQ_Constants.PageTitle_Home));
            }
        }

        [TestMethod]
        public void TopMenu_Existence()
        {
            using (HomePage homepage = new HomePage(new TestingBrowser(Browser.Chrome, BrowserWindowSize.Desktop_1524x768)))
            {
                homepage.GotoPage(TestingHelper.FullUrl(MCIQ_Constants.PageUrl_Home));
                bool topmenucheck = homepage.CheckTopMenu();
                Assert.IsTrue(topmenucheck);
            }
        }

        [TestMethod]
        public void TopMenu_Home_Click()
        {
            using (HomePage homepage = new HomePage(new TestingBrowser(Browser.Firefox, BrowserWindowSize.Desktop_1524x768)))
            {
                homepage.GotoPage(TestingHelper.FullUrl(MCIQ_Constants.PageUrl_Home));
                homepage.SelectHomeLink();
                Assert.IsTrue(homepage.IsAtPageTitle(MCIQ_Constants.PageTitle_Home));
            }
        }

        [TestMethod]
        public void TopMenu_WhatIsMyRisk_Click()
        {
            using (HomePage homepage = new HomePage(new TestingBrowser(Browser.Firefox, BrowserWindowSize.Maximium)))
            {
                homepage.GotoPage(TestingHelper.FullUrl(MCIQ_Constants.PageUrl_Home));
                homepage.SelectWhatIsMyRiskLink();
                Assert.IsTrue(homepage.IsAtPageTitle(MCIQ_Constants.PageTitle_What_Is_My_Risk));
            }
        }
    }    
}

