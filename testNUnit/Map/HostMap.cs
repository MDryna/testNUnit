using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testNUnit.Map
{
    public class HostMap : BaseTest
    {
        public IWebElement _buttonCourses => driver.FindElement(By.CssSelector("[title='Курси']"));
        public IWebElement _signInButton => driver.FindElement(By.CssSelector("[class='show-for-medium']"));
        public readonly By _popperWithCourses = By.XPath("//ul[@class='DropdownCoursesList_coursesList__xjALB']/li"); //used in LINQ
        //public readonly By _lastElementOnPopper = By.XPath(".//ul[contains(@class, 'DropdownCoursesList_coursesList__xjALB')][12]"); //doesn't work
        public readonly By _lastElementOnPopper = By.XPath("//a[@title='Recruiter flex']");
        public IWebElement _linkGoogle => driver.FindElement(By.CssSelector("[title='Google']"));
        public IWebElement _logoBlock => driver.FindElement(By.CssSelector("[id='companies']"));
        public IWebElement _carrouselReviews => driver.FindElement(By.CssSelector("[data-qa='right-reviews-button']"));
        public IWebElement _btnAcceptCookies => driver.FindElement(By.CssSelector("[data-qa='accept-cookies-button']"));
        public IWebElement _linkDOU => driver.FindElement(By.CssSelector("[href='https://dou.ua/lenta/articles/dou-projector-mate-academy/']"));
        public IWebElement _helpPopup => driver.FindElement(By.CssSelector("[class='Button_secondary__DNIuD Button_large__rIMVg']"));
        public IWebElement _messengersIcons => driver.FindElement(By.CssSelector("[href='#page-top']")); // Is not used. last loaded element on the page

    }
}



