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
    public class HostPageObject : BaseTest
    {
        private readonly BaseMap BaseMap = new BaseMap();
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));


        //Constructor
        public HostPageObject()
        {
        
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlToBe("https://mate.academy/"));
           // wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BaseMap.HostMap._messengersIcons));
        }

        public void SignInClick()
        {
            this.BaseMap.HostMap._signInButton.Click();
        }

        public void ClickBtnCourses()
        {
            this.BaseMap.HostMap._buttonCourses.Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BaseMap.HostMap._lastElementOnPopper));
        }
        

        //LINQ
        public void RedirectingToCourses(string courseName)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(BaseMap.HostMap._popperWithCourses));
            var courses = driver.FindElements(BaseMap.HostMap._popperWithCourses).First(x => x.Text == courseName);
            courses.Click();

        }

        public void ClickQaOnPopper()
        {
            IWebElement btnQA = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BaseMap.HostMap._qaOptionOnPopper));
            btnQA.Click();
        }

        //Scroll to element method
        public void ComppanysLogoBlock()
        {
           js.ExecuteScript("arguments[0].scrollIntoViewIfNeeded()", BaseMap.HostMap._linkGoogle);
        }

        public bool ChecklogoBlock()
        {
            try
            {
                bool logo = BaseMap.HostMap._logoBlock.Displayed;
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void RefuseHelp()
        {
            var clickRefuseHelp = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BaseMap.HostMap._helpPopup));
            clickRefuseHelp.Click();
        }
        //Scroll to element method
        public void ScrollToCarrousel()
        {
            js.ExecuteScript("arguments[0].scrollIntoView(true);", BaseMap.HostMap._carrouselReviews);
         
        }

        public void ClickAcceptCookies()
        {
            var btnAcceptCookies = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BaseMap.HostMap._btnAcceptCookies));
            btnAcceptCookies.Click();
        }


        public void OpenDOUlink()
        {
            
           wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BaseMap.HostMap._buttonLearnForFreeInHeader));
          // js.ExecuteScript("arguments[0].scrollIntoView(true);", BaseMap.HostMap._linkDOU);
           var clickDou = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BaseMap.HostMap._linkDOU));
            clickDou.Click();
        }

        public void ClickButtonChangeLocalization()
        {
           var changeLocalization = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BaseMap.HostMap._buttonChangeLocalization));
            changeLocalization.Click();
        }
        //потрібно дописати
        public void OpenCountryDropDown()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BaseMap.HostMap._lastElementOnLocalizationPopup));
            var openDropdown = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BaseMap.HostMap._dropdownCountry));
            openDropdown.Click(); 
        }

        public void SelectEurope()
        {
            var selectEurope = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BaseMap.HostMap._europeOptionInDropdown));
            selectEurope.Click();
        }

        public bool CheckEuropeIsSelected()
        {
            try
            {
                bool logo = BaseMap.HostMap._europeOptionSelected.Displayed;
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
