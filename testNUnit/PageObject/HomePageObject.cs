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
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        private readonly BaseMap BaseMap = new BaseMap();

        //конструктор
        //public HomePageObject()
        //{
        //    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlToBe("https://mate.academy/learn?course=all_courses"));
       // }
        
        public void SignInClick()
        {
            this.BaseMap.HomeMap._signInButton.Click();
        }

        // метод відображає current url
        public string OpenURL()
        {
            string url = driver.Url;
            return url;
        }


        public void OpenSchedulePage()
        {
            IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BaseMap.HomeMap._btnSchedule));
            element.Click();
        }


        public void ClickBtnCourses() => BaseMap.HomeMap._buttonCourses.Click();

        //LINQ
        public void RedirectingToCourses(string courseName)
        {
            var courses = driver.FindElements(BaseMap.HomeMap._popperWithCourses).First(x => x.Text == courseName);
            courses.Click();

        }

        public void OpenDropdownOnHeader() => BaseMap.HomeMap._dropdownUserAccount.Click();

        public void ClickLogOut() => BaseMap.HomeMap._btnLogOut.Click();

        //СКРОЛ
        public void ComppanysLogoBlock()
        {
            string linkGoogle = (string)js.ExecuteScript("arguments[0].scrollIntoViewIfNeeded()", BaseMap.HomeMap._linkGoogle);
        }

        public bool ChecklogoBlock()
        {
            try
            {
                bool logo =  BaseMap.HomeMap._logoBlock.Displayed;
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        public void ScrollToCarrousel()
        {
            var carrouselClick = js.ExecuteScript("arguments[0].scrollIntoView(true);", BaseMap.HomeMap._carrouselReviews);
        }

        public void ClickAcceptCookies()
        {
            var btnAcceptCookies = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BaseMap.HomeMap._btnAcceptCookies));
            btnAcceptCookies.Click();
        }
           
        public void OpenDOUlink()
        {
          js.ExecuteScript("arguments[0].scrollIntoView(true);", BaseMap.HomeMap._linkDOU);
          var linkDOU  = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BaseMap.HomeMap._linkDOU));
          linkDOU.Click();
        }


        //action.ScrollToElement(BaseMap.HomeMap._carrouselReviews).Perform();



    }

  
}
