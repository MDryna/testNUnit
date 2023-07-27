using OpenQA.Selenium;

namespace testNUnit.Map;

public class ScheduleMap : BaseTest
{
    public  IWebElement _scheduleTable => driver.FindElement(By.CssSelector("[data-qa='schedule-table']"));
    public  IWebElement _dropdownTime => driver.FindElement(By.CssSelector(".Select_select__Q_RpM"));
    public  IWebElement _dropdownOptionDay => driver.FindElement(By.CssSelector("[tabindex='-1']"));
    public  IWebElement _dropdownSelectedDay => driver.FindElement(By.XPath("//div[text() = 'День']"));
    public IWebElement _timegridIndicator => driver.FindElement(By.CssSelector("[class='fc-timegrid-now-indicator-line']"));

    
}