using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testNUnit.PageObject;

namespace testNUnit
{
    class Tests : BaseTest
    {

        
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

        //перевірка що після логіну відкривається юрл кабінету користувача
        [Test]
        public void TestUrlAfterLogIn()
        {
            this.BasePage.HomePageObject.SignInClick();
            this.BasePage.AuthorizationPageObject.Login(TestSettings.login, TestSettings.password);
            Thread.Sleep(8000);
            string currentUrl = this.BasePage.HomePageObject.OpenURL();
            Thread.Sleep(5000);
            
            Assert.That(currentUrl, Is.EqualTo("https://mate.academy/learn?course=all_courses"), "Failed test, url doesn't match with /mate.academy/learn?course=all_courses");
        }

        //перевірка тайтла у веб вкладці особистого кабінету
        [Test]
        public void TestWebTitleOnUserAccount()
        {
            this.BasePage.HomePageObject.SignInClick();
            this.BasePage.AuthorizationPageObject.Login(TestSettings.login, TestSettings.password);
            Thread.Sleep(5000);
            
            Assert.That(driver.Title, Is.EqualTo("Learn | Mate academy"));
        }

        //перевірка тайтла із вейтом
        [Test]
        public void TestLogOUT()
        {
            
            this.BasePage.HomePageObject.SignInClick();
            this.BasePage.AuthorizationPageObject.Login(TestSettings.login, TestSettings.password);
            this.BasePage.HomePageObject.ClickDropdownUserAccount();
            Thread.Sleep(5000);
            this.BasePage.HomePageObject.ClickLogOut();
            Thread.Sleep(4000);
            
            Assert.That(driver.Title, Is.EqualTo("Вхід в особистий кабінет студента | Mate academy"));
        }


        [Test]
        public void TestScheduleTable_Displayed()
        {
            this.BasePage.HomePageObject.SignInClick();
            this.BasePage.AuthorizationPageObject.Login(TestSettings.login, TestSettings.password);
            Thread.Sleep(4000);
            this.BasePage.HomePageObject.OpenSchedulePage();
            Thread.Sleep(4000);

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
            Thread.Sleep(4000);
            this.BasePage.HomePageObject.OpenSchedulePage();
            Thread.Sleep(4000);
            this.BasePage.SchedulePageObject.OpenTimeDrop();
            Thread.Sleep(2000);
            this.BasePage.SchedulePageObject.ClickDayOnDropdownTime();
            
            Assert.IsTrue(this.BasePage.SchedulePageObject.CheckDropdownOptionSelected(), "Failed test, option is not selected from time dropdown on the Schedule page");

        }
    }

}