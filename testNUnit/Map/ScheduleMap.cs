using OpenQA.Selenium;

namespace testNUnit.Map;

public class ScheduleMap : BaseTest
{
    public  IWebElement _scheduleTable => driver.FindElement(By.CssSelector("[data-qa='schedule-table']"));
        public IWebElement _timegridIndicator => _scheduleTable.FindElement(By.ClassName("fc-timegrid-now-indicator-line")); 
    public IWebElement _scheduleHeader => driver.FindElement(By.ClassName("MateCalendar_headerWrapper__yxSVL"));
        //public  IWebElement _dropdownTime => _scheduleHeader.FindElement(By.CssSelector(".Select_select__Q_RpM"));
        public IWebElement _dropdownTime => _scheduleHeader.FindElement(By.ClassName("Select_select__Q_RpM"));
        public  IWebElement _dropdownOptionDay => _scheduleHeader.FindElement(By.Id("react-select-2-option-0"));
        public  IWebElement _dropdownSelectedDay => _scheduleHeader.FindElement(By.XPath("//div[text() = 'День']"));
    

    
}