using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testNUnit.Map;

namespace testNUnit.PageObject
{
    public class SchedulePageObject : BaseTest
    {
        private readonly BaseMap BaseMap = new BaseMap();

        public bool CheckScheduleTableDisplayed()
        {
            try
            {
                bool displayed = BaseMap.ScheduleMap._scheduleTable.Displayed;
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        public void OpenTimeDrop() =>  BaseMap.ScheduleMap._dropdownTime.Click();

        public void ClickDayOnDropdownTime() =>  BaseMap.ScheduleMap._dropdownOptionDay.Click();

        public bool CheckDropdownOptionSelected()
        {
            try
            {
                bool displayed =  BaseMap.ScheduleMap._dropdownSelectedDay.Displayed;
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }



    }
}
