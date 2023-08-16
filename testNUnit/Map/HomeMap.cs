using OpenQA.Selenium;

namespace testNUnit.Map;

public class HomeMap : BaseTest
{
    public IWebElement _coursesGridOnHomePage => driver.FindElement(By.ClassName("CoursesPage_courses__W1dhv"));
    public IWebElement _sidebar => driver.FindElement(By.ClassName("Sidebar_sidebarWrapper__lr3ij"));
        public  IWebElement _btnSchedule => _sidebar.FindElement(By.CssSelector("[title='Календар']"));

    public IWebElement _btnProfileDropdown => driver.FindElement(By.CssSelector("[data-qa='profile-dropdown']")); 
        public IWebElement _dropdownUserAccount => _btnProfileDropdown.FindElement(By.XPath("//span[text()= 'Марія Дрина']"));
        public IWebElement _btnLogOut => _btnProfileDropdown.FindElement(By.XPath(".//li[contains(@class, 'ProfileDropdown_item__UpuW6')][6]"));


}