using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testNUnit.Map;
using OpenQA.Selenium;

namespace testNUnit.PageObject
{
    public class EnglishHostPageObject : BaseTest
    {
        private readonly BaseMap BaseMap = new BaseMap();
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

        public EnglishHostPageObject()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlToBe(TestSettings.HostUrl + "en-eu"));
        }

        public string OpenURL()
        {
            string url = driver.Url;
            return url;
        }
    }
}
