using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testNUnit.Map
{
    public class FrontendMap : BaseTest
    {
        public IWebElement _contentContainer => driver.FindElement(By.ClassName("CourseHeroSection_sectionWrapper__yjw_1"));
            public IWebElement _titleOnFrontendPage => _contentContainer.FindElement(By.XPath("//h1[text()='Frontend Developer онлайн-курс з ']"));
            public IWebElement _lendingTextFE => _contentContainer.FindElement(By.XPath("//p[text()= 'Вільних місць у хвилі набору']"));
    }
}
