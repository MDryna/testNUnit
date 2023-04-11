using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testNUnit.Map;

namespace testNUnit.PageObject
{
    public class HomePageObject : BaseTest
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        private readonly BaseMap BaseMap = new BaseMap();

        // метод кліку на _signInButton
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
            WebElement element = (WebElement)wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BaseMap.HomeMap._btnSchedule));
            element.Click();
        }


        public void ClickBtnCourses() => BaseMap.HomeMap._buttonCourses.Click();

        //LINQ
        public void RedirectingToCourses(string courseName)
        {
            var courses = driver.FindElements(BaseMap.HomeMap._popperWithCourses).First(x => x.Text == courseName);
            courses.Click();

        }

        public void ClickDropdownUserAccount()
        {

            WebElement dropdownUserAccount = (WebElement)wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BaseMap.HomeMap._dropdownUserAccount));
            dropdownUserAccount.Click();

        }

        public void ClickLogOut()
        {

            WebElement elementdropdownUserAccount = (WebElement)wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BaseMap.HomeMap._dropdownUserAccount));
            elementdropdownUserAccount.Click();
            Thread.Sleep(100);
            BaseMap.HomeMap._btnLogOut.Click();
        }
        //public void RedirectingViaSideBar(string title)
        //{
        //    SelectElement element = new SelectElement(_sidebar);
        //    element.SelectByText(title);
        //    _sidebar.Click();

        //}



    }
}
