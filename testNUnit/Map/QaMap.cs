using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testNUnit.Map
{
    public class QaMap : BaseTest 
    {
        public IWebElement _contentContainer => driver.FindElement(By.ClassName("CourseHeroSection_sectionWrapper__yjw_1")); 
            public IWebElement _lendingTextQA => _contentContainer.FindElement(By.XPath("//h1[text()='QA-інженер: ручне та автоматизоване тестування ПЗ']"));
            public IWebElement _courseCounterLastElement => _contentContainer.FindElement(By.ClassName("CourseHeroCTACounter_counter__ba8da"));
       
    }
}
