using OpenQA.Selenium;

namespace testNUnit.Map;

public class HomeMap : BaseTest
{
    public IWebElement _coursesGridOnHomePage => driver.FindElement(By.CssSelector("[class='CoursesPage_courses__W1dhv']"));
    public  IWebElement _btnSchedule => driver.FindElement(By.CssSelector("[href='/schedule']"));
    public  IWebElement _dropdownUserAccount => driver.FindElement(By.XPath("//span[text()= 'Марія Дрина']"));
    //public IWebElement _btnLogOut => driver.FindElement(By.CssSelector("[data-qa='log-out-link']")); //2 elements with the same locator
    public IWebElement _btnLogOut => driver.FindElement(By.XPath("//ul[@class='Header_list___Qfpa']//button[@data-qa='log-out-link']"));
    public IWebElement _btnProfileDropdown => driver.FindElement(By.CssSelector("[data-qa='profile-dropdown']"));

}