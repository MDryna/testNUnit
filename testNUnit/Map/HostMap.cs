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
        public IWebElement _messengersIcons => driver.FindElement(By.XPath("//div[@class='FloatIcons_wrapper__QxK50 FloatIcons_pageNotScrolled__ym8sH']"));
        public IWebElement _signInButton => driver.FindElement(By.XPath("//div[@class='show-for-medium']"));
        public IWebElement _buttonCourses => driver.FindElement(By.XPath("//button[@class='Button_gray__A8i5Z Button_large__rIMVg HeaderCoursesDropdown_triggerButton__9_0nV Button_button__bwept Button_withIcon__o4QSd']"));
        public readonly By _popperWithCourses = By.XPath("//ul[@class='DropdownCoursesList_coursesList__xjALB']/li");
        public IWebElement _linkGoogle => driver.FindElement(By.XPath("//img[@title='Google']"));
        public IWebElement _logoBlock => driver.FindElement(By.XPath("//div[@class='LogoItemsListBlock_list__1OxkJ mb-32 small-mb-24']"));
        public IWebElement _carrouselReviews => driver.FindElement(By.XPath("//button[@data-qa='right-reviews-button']"));
        public IWebElement _btnAcceptCookies => driver.FindElement(By.XPath("//button[@data-qa='accept-cookies-button']"));
        public IWebElement _linkDOU => driver.FindElement(By.XPath("//a[@href='https://dou.ua/lenta/articles/dou-projector-mate-academy/']"));
    }
}



