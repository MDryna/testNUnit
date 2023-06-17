using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testNUnit.Map;

namespace testNUnit.PageObject
{
    public class FrontendPageObject : BaseTest
    {
        private readonly BaseMap BaseMap = new BaseMap();
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

        //Constructor
        public FrontendPageObject()
        {
            
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlToBe(TestSettings.HostUrl + "courses/frontend"));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BaseMap.FrontendMap._lendingTextFE));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy((By)BaseMap.FrontendMap._lendingTextFE));

        }

        public bool CheckTitle()
        {
            try
            {
             
                bool logo = BaseMap.FrontendMap._titleOnFrontendPage.Displayed;
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
