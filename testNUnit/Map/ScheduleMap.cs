using OpenQA.Selenium;

namespace testNUnit.Map;

public class ScheduleMap : BaseTest
{
    public  IWebElement _scheduleTable => driver.FindElement(By.XPath("//div[@data-qa='schedule-table']"));
    public  IWebElement _dropdownTime => driver.FindElement(By.CssSelector(".Select_select__Q_RpM.HeaderControls_timeFrameSelect__4JixO.Select_borderlessMode__Bnmc0.Select_menuWidthByControl__JQI99.css-2b097c-container"));
    public  IWebElement _dropdownOptionDay => driver.FindElement(By.XPath("//div[@tabindex='-1']"));
    public  IWebElement _dropdownSelectedDay => driver.FindElement(By.XPath("//div[text() = 'День']"));
}