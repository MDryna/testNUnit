using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace testNUnit.Map
{
    public class HostMap : BaseTest
    {
        public IWebElement _header => driver.FindElement(By.CssSelector("[data-qa='platform-header']")); 
            public IWebElement _buttonCourses => _header.FindElement(By.CssSelector("[title='Курси']"));
            public IWebElement _signInButton => _header.FindElement(By.CssSelector("[title='Кабінет']"));
            public IWebElement _buttonLearnForFreeInHeader => _header.FindElement(By.CssSelector("[data-role='desktop-cta']"));
            public IWebElement _buttonChangeLocalization => _header.FindElement(By.CssSelector("[title='Змінити країну або мову']"));

        public IWebElement _popperCurses => driver.FindElement(By.ClassName("HeaderCoursesDropdown_dropdownWrapper__3Agil"));
             public IWebElement _qaOptionPopper => _popperCurses.FindElement(By.CssSelector("[title='QA engineer']"));
             public IWebElement _lastElementPopper => _popperCurses.FindElement(By.CssSelector("[title='Recruiter flex']"));

             // public readonly By _popperWithCourses = By.XPath("//ul[@class='DropdownCoursesList_coursesList__xjALB']/li"); //used in LINQ
             public readonly By _popperWithCourses = By.ClassName("DropdownCoursesList_coursesListItem__5fXRO"); //used in LINQ
       
        public IWebElement _companiesBlock => driver.FindElement(By.CssSelector("div[id='companies']"));
            public IWebElement _linkGoogle => _companiesBlock.FindElement(By.CssSelector("[alt='Google']"));

        public IWebElement _publishingReviews => driver.FindElement(By.Id("publishing-reviews"));
            public IWebElement _carrouselReviews => _publishingReviews.FindElement(By.CssSelector("[data-qa='right-reviews-button']"));
            public IWebElement _linkDOU => _publishingReviews.FindElement(By.CssSelector("[href='https://dou.ua/lenta/articles/dou-projector-mate-academy/']"));

        public IWebElement _dialog => driver.FindElement(By.CssSelector("[role='dialog']"));
            public IWebElement _lastElementOnLocalizationPopup => _dialog.FindElement(By.XPath("//div[@class='CountrySelectorElements_inputsWrapper__KtmHI']/label[3]"));
            public IWebElement _dropdownCountry => _dialog.FindElement(By.CssSelector("[data-qa='input-field-location']"));
            public IWebElement _btnSubmit => _dialog.FindElement(By.CssSelector("[type='submit']"));
        public IWebElement _europeOptionInDropdown => driver.FindElement(By.Id("react-select-location-selector-option-0"));
        public IWebElement  _animatedSection => driver.FindElement(By.CssSelector("[data-animated-section='true']"));
            public IWebElement _messengersIcons => _animatedSection.FindElement(By.CssSelector("[href='#page-top']")); // Is not used. last loaded element on the page
        public IWebElement _btnAcceptCookies => driver.FindElement(By.CssSelector("[data-qa='accept-cookies-button']"));
       
        
     

    }
}



