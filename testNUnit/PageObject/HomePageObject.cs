using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using testNUnit.Map;

namespace testNUnit.PageObject
{
    public class HomePageObject : BaseTest
    {
        
        private readonly BaseMap BaseMap = new BaseMap();
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

        //Constructor
        public HomePageObject()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlToBe(TestSettings.HostUrl + "learn?course=all_courses"));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BaseMap.HomeMap._coursesGridOnHomePage));
        }


        // метод відображає current url
        public string OpenURL()
        {
            string url = driver.Url;
            return url;
        }


        public void OpenSchedulePage()
        {
            IWebElement btnSchedule = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BaseMap.HomeMap._btnSchedule));
            btnSchedule.Click();
        }



        public void OpenDropdownOnHeader()
        {
            IWebElement btnLogOut = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BaseMap.HomeMap._dropdownUserAccount));
            btnLogOut.Click();
        }
          

        public void ClickLogOut()
        {

            IWebElement btnLogOut = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BaseMap.HomeMap._btnLogOut));
            btnLogOut.Click();
        }
            


        //public void ClickProfileDropdown()
        //{
        //    this.BaseMap.HomeMap._btnProfileDropdown.Click();
        //    var dropList = driver.FindElement(By.XPath("//ul[@class= 'ProfileDropdown_dropdownContent__JNDGI ProfileDropdown_dropdownOpened__3Lq7h']"));
        //    var select = new SelectElement(dropList);
            //     SelectElement element = new SelectElement(dropList);
         //   select.SelectByText("Вийти");
        //}

        //action.ScrollToElement(BaseMap.HomeMap._carrouselReviews).Perform();



    }

  
}
