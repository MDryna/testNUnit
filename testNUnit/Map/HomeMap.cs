using OpenQA.Selenium;

namespace testNUnit.Map;

public class HomeMap : BaseTest
{
    public  IWebElement _signInButton => driver.FindElement(By.XPath("//div[@class='show-for-medium']"));
    public  IWebElement _btnSchedule => driver.FindElement(By.XPath("//a[@href='/schedule']"));
    public  IWebElement _buttonCourses => driver.FindElement(By.XPath("//button[@class='Button_gray__A8i5Z Button_large__rIMVg HeaderCoursesDropdown_triggerButton__9_0nV Button_button__bwept Button_withIcon__o4QSd']"));
    public readonly By _popperWithCourses = By.XPath("//ul[@class='DropdownCoursesList_coursesList__xjALB']/li");
    public  IWebElement _dropdownUserAccount => driver.FindElement(By.XPath("//span[text()= 'Марія Дрина']"));
    public  IWebElement _btnLogOut => driver.FindElement(By.XPath("//button[@data-qa='log-out-link']"));
}