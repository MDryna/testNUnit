using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal.Execution;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using testNUnit.PageObject;

namespace testNUnit
{
    class Tests : BaseTest
    {
         
        public static WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
    

        //LINQ перевірка перенаправлення на FE Course page
        [Test,Category("Smoke Testing")]
        public void TestCourseFEopens()
        {
            this.BasePage.HostPageObject.ClickBtnCourses();
            this.BasePage.HostPageObject.RedirectingToCourses(TestSettings.courseFE);
            Assert.IsTrue(this.BasePage.FrontendPageObject.CheckTitle(), "Incorect title or page is not opened");
           
        }
        //test with root selectors
        [Test, Category("Smoke Testing")]
        public void CourseQAopens()
        {
            this.BasePage.HostPageObject.ClickBtnCourses();
            this.BasePage.HostPageObject.ClickQa();
            Assert.IsTrue(this.BasePage.QaPageObject.CheckTitle(), "Incorect title or page is not opened");
        }

        [Test, Category("Smoke Testing")]
        public void TestUrlAfterLogIn()
        {
            this.BasePage.HostPageObject.SignInClick();
            this.BasePage.AuthorizationPageObject.Login(TestSettings.login, TestSettings.password);   
            string currentUrl = this.BasePage.HomePageObject.OpenURL();
            Assert.That(currentUrl, Is.EqualTo(TestSettings.HostUrl+"learn?course=all_courses"), "Failed test, url doesn't match with /mate.academy/learn?course=all_courses");
        }

    

        //перевірка тайтла у веб вкладці особистого кабінету
        [Test, Category("Regression Testing")]
        public void TestWebTitleOnUserAccount()
        {
            this.BasePage.HostPageObject.SignInClick();
            this.BasePage.AuthorizationPageObject.Login(TestSettings.login, TestSettings.password);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TitleContains("Learn | Mate academy"));
            Assert.That(driver.Title, Is.EqualTo("Learn | Mate academy"));
        }

  
        [Test, Category("Smoke Testing")]
        public void TestLogOUT()
        {
            this.BasePage.HostPageObject.SignInClick();
            this.BasePage.AuthorizationPageObject.Login(TestSettings.login, TestSettings.password);
            this.BasePage.HomePageObject.OpenDropdownOnHeader();
            this.BasePage.HomePageObject.ClickLogOut();
            Assert.That(this.BasePage.AuthorizationPageObject.CheckLogOutUrl(), "User is not logged out");
        }
        
        


        [Test, Category("Smoke Testing")]
        public void TestScheduleTable_Displayed()
        {
            this.BasePage.HostPageObject.SignInClick();
            this.BasePage.AuthorizationPageObject.Login(TestSettings.login, TestSettings.password);
            this.BasePage.HomePageObject.OpenSchedulePage();
            Assert.IsTrue(this.BasePage.SchedulePageObject.CheckScheduleTableDisplayed(), "Schedule Table is not displayed");
        }

        [Test, Category("Smoke Testing")]
        public void CheckErrorDisplayed_withNon_existing_Credentials()
        {
            this.BasePage.HostPageObject.SignInClick();
            this.BasePage.AuthorizationPageObject.FailedLogin_CheckErrorDisplayed(RandomData.GenereteRandomEmail(TestSettings.mail), RandomData.GenereteRandomPassword());
            Assert.IsTrue(this.BasePage.AuthorizationPageObject.CheckErrorDisplayed(), "Failed test, Validation error is not displayed after submitting non-existing credentials");

        }

        [Test, Category("Smoke Testing")]
        public void TestSelectOptionInTimeDropdown()
        {
            this.BasePage.HostPageObject.SignInClick();
            this.BasePage.AuthorizationPageObject.Login(TestSettings.login, TestSettings.password);
            this.BasePage.HomePageObject.OpenSchedulePage();
            this.BasePage.SchedulePageObject.OpenTimeDrop();
            this.BasePage.SchedulePageObject.ClickDayOnDropdownTime();
            Assert.IsTrue(this.BasePage.SchedulePageObject.CheckDropdownOptionSelected(), "Failed test, option is not selected from time dropdown on the Schedule page");
        }

        [Test, Category("Smoke Testing")]
        public void ChangeCountry()
        {
            this.BasePage.HostPageObject.ClickButtonChangeLocalization();
            this.BasePage.HostPageObject.OpenCountryDropDown();
            this.BasePage.HostPageObject.SelectEurope();
            this.BasePage.HostPageObject.SubmitLocalization();
            string currentUrl = this.BasePage.EnglishHostPageObject.OpenURL();
            Assert.That(currentUrl, Is.EqualTo(TestSettings.HostUrl + "en-eu"), "Failed test, url doesn't match with /en-eu, Localization is not changed");
          
        }

        [Test, Category("Regression Testing")]
        public void CheckLogoBlock()
        { 
           this.BasePage.HostPageObject.ComppanysLogoBlock();
           Assert.IsTrue(BasePage.HostPageObject.ChecklogoBlock(), "Failed test, Logos block is not founded on the page.");
        }

        [Test, Category("Regression Testing")]
        public void CheckLinkInReviews()
        {
            //this.BasePage.HostPageObject.RefuseHelp();

            this.BasePage.HostPageObject.ClickAcceptCookies();
            this.BasePage.HostPageObject.ScrollToCarrousel();
            this.BasePage.HostPageObject.OpenDOUlink();

        }


    }

}