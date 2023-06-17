using OpenQA.Selenium;

namespace testNUnit.Map;

public class HomeMap : BaseTest
{
    public IWebElement _coursesGridOnHomePage => driver.FindElement(By.XPath("//section[@class='CoursesPage_courses__W1dhv']"));
    public  IWebElement _btnSchedule => driver.FindElement(By.XPath("//a[@href='/schedule']"));
    public  IWebElement _dropdownUserAccount => driver.FindElement(By.XPath("//span[text()= 'Марія Дрина']"));
    public IWebElement _btnLogOut => driver.FindElement(By.XPath("//button[@data-qa='log-out-link']"));
    public IWebElement _btnProfileDropdown => driver.FindElement(By.XPath("//div[@data-qa='profile-dropdown']"));

}