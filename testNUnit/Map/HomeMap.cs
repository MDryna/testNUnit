using OpenQA.Selenium;

namespace testNUnit.Map;

public class HomeMap : BaseTest
{
    public  IWebElement _signInButton => driver.FindElement(By.XPath("//div[@class='show-for-medium']"));
    public  IWebElement _btnSchedule => driver.FindElement(By.XPath("//a[@href='/schedule']"));
    public  IWebElement _buttonCourses => driver.FindElement(By.XPath("//button[@class='Button_gray__A8i5Z Button_large__rIMVg HeaderCoursesDropdown_triggerButton__9_0nV Button_button__bwept Button_withIcon__o4QSd']"));
    public readonly By _popperWithCourses = By.XPath("//ul[@class='DropdownCoursesList_coursesList__xjALB']/li");
    public  IWebElement _dropdownUserAccount => driver.FindElement(By.XPath("//span[text()= 'Марія Дрина']"));
    public IWebElement _btnLogOut => driver.FindElement(By.XPath("//button[@data-qa='log-out-link']"));

    public IWebElement _linkDOU => driver.FindElement(By.XPath("//a[@href='https://dou.ua/lenta/articles/dou-projector-mate-academy/']"));
    public IWebElement _linkGoogle => driver.FindElement(By.XPath("//img[@title='Google']"));
    public IWebElement _logoBlock  => driver.FindElement(By.XPath("//div[@class='LogoItemsListBlock_list__1OxkJ mb-32 small-mb-24']"));
    public IWebElement _carrouselReviews => driver.FindElement(By.XPath("//button[@data-qa='right-reviews-button']"));
    public IWebElement _btnAcceptCookies => driver.FindElement(By.XPath("//button[@data-qa='accept-cookies-button']"));
    
  
      
}