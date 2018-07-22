

namespace TestFramework
{
    public class HomePage : BaseTestPage
    { 
        public HomePage(TestingBrowser br):base(br)
        {
            
        }

        public bool CheckTopMenu()
        {
            return Topmenu_HOME.Text != null &&
                Topmenu_What_Is_My_Risk.Text != null &&
                Topmenu_ABOUT_My_CancerIQ.Text != null &&
                Topmenu_ABOUT_Cancer_Risk.Text != null &&
                Topmenu_For_HealthCare_Providers.Text != null ;
        }

        public void SelectHomeLink()
        {
            Topmenu_HOME.Click();           
        }

        public void SelectWhatIsMyRiskLink()
        {
            Topmenu_What_Is_My_Risk.Click();
        }
    }
}