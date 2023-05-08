using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using testNUnit.PageObject;

namespace testNUnit
{
    class Tests : BaseTest
    {
         
         public static WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
        
        //LINQ перевірка перенаправлення на FE Course page
        [Test]
        public void TestCourseFEopens()
        {
            this.BasePage.HomePageObject.ClickBtnCourses();
            this.BasePage.HomePageObject.RedirectingToCourses(TestSettings.courseFE);
        }
        
        
        //LINQ перевірка перенаправлення на QA Course page
        [Test]
        public void TestCourseQAopens()
        {
            this.BasePage.HomePageObject.ClickBtnCourses();
            this.BasePage.HomePageObject.RedirectingToCourses(TestSettings.courseQA);
        }
        
        
        [Test]
        public void TestUrlAfterLogIn()
        {
            this.BasePage.HomePageObject.SignInClick();
            this.BasePage.AuthorizationPageObject.Login(TestSettings.login, TestSettings.password);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlToBe(TestSettings.HostUrl+"learn?course=all_courses"));
           string currentUrl = this.BasePage.HomePageObject.OpenURL();
    
            Assert.That(currentUrl, Is.EqualTo(TestSettings.HostUrl+"learn?course=all_courses"), "Failed test, url doesn't match with /mate.academy/learn?course=all_courses");
        }

    

        //перевірка тайтла у веб вкладці особистого кабінету
        [Test]
        public void TestWebTitleOnUserAccount()
        {
            this.BasePage.HomePageObject.SignInClick();
            this.BasePage.AuthorizationPageObject.Login(TestSettings.login, TestSettings.password);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlToBe(TestSettings.HostUrl+"learn?course=all_courses"));
            Assert.That(driver.Title, Is.EqualTo("Learn | Mate academy"));
        }

  
        [Test]
        public void TestLogOUT()
        {
            
            this.BasePage.HomePageObject.SignInClick();
            this.BasePage.AuthorizationPageObject.Login(TestSettings.login, TestSettings.password);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlToBe(TestSettings.HostUrl+"learn?course=all_courses"));
            this.BasePage.HomePageObject.OpenDropdownOnHeader();
           
            this.BasePage.HomePageObject.ClickLogOut();
           
            var urlToBe = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlToBe(TestSettings.HostUrl+"sign-in"));
            Assert.That(driver.Title, Is.EqualTo("Вхід в особистий кабінет студента | Mate academy"));
        }


        [Test]
        public void TestScheduleTable_Displayed()
        {
            this.BasePage.HomePageObject.SignInClick();
            this.BasePage.AuthorizationPageObject.Login(TestSettings.login, TestSettings.password);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlToBe(TestSettings.HostUrl+"learn?course=all_courses"));
            this.BasePage.HomePageObject.OpenSchedulePage();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlToBe(TestSettings.HostUrl+"schedule"));
    
            Assert.IsTrue(this.BasePage.SchedulePageObject.CheckScheduleTableDisplayed(), "Schedule Table is not displayed");
        }

        [Test]
        public void CheckErrorDisplayed_withNon_existing_Credentials()
        {
            this.BasePage.HomePageObject.SignInClick();
            this.BasePage.AuthorizationPageObject.FailedLogin_CheckErrorDisplayed(RandomData.GenereteRandomEmail(TestSettings.mail), RandomData.GenereteRandomPassword());

            Assert.IsTrue(this.BasePage.AuthorizationPageObject.CheckErrorDisplayed(), "Failed test, Validation error is not displayed after submitting non-existing credentials");

        }

        [Test]
        public void TestSelectOptionInTimeDropdown()
        {
            this.BasePage.HomePageObject.SignInClick();
            this.BasePage.AuthorizationPageObject.Login(TestSettings.login, TestSettings.password);
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlToBe("https://mate.academy/learn?course=all_courses"));
            this.BasePage.HomePageObject.OpenSchedulePage();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlToBe(TestSettings.HostUrl+"schedule"));
            this.BasePage.SchedulePageObject.OpenTimeDrop();
            this.BasePage.SchedulePageObject.ClickDayOnDropdownTime();
            
            Assert.IsTrue(this.BasePage.SchedulePageObject.CheckDropdownOptionSelected(), "Failed test, option is not selected from time dropdown on the Schedule page");

        }

        [Test]
        public void CheckLogoBlock()
        { 
            this.BasePage.HomePageObject.ComppanysLogoBlock();
            
           Assert.IsTrue(BasePage.HomePageObject.ChecklogoBlock(), "Failed test, Logos block is not founded on the page.");
        }

        [Test]
        public void CheckLinkInReviews()
        {
            this.BasePage.HomePageObject.ScrollToCarrousel();
            Thread.Sleep(1000);
            this.BasePage.HomePageObject.ClickAcceptCookies();
            Thread.Sleep(1000);
            this.BasePage.HomePageObject.OpenDOUlink();
        }

    }

}