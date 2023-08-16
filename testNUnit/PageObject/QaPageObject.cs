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
    public class QaPageObject : BaseTest
    {
        private readonly BaseMap BaseMap = new BaseMap();
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

        public QaPageObject()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlToBe(TestSettings.HostUrl + "courses/qa"));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BaseMap.QaMap._courseCounterLastElement));
        }


        public bool CheckTitle()
        {
            try
            {

                bool logo = BaseMap.QaMap._lendingTextQA.Displayed;
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
