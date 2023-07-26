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
        public IWebElement _titleOnFrontendPage => driver.FindElement(By.XPath("//h1[text()='Frontend Developer онлайн-курс з ']"));
        public IWebElement _alertOnFrontendPage => driver.FindElement(By.CssSelector("[role='dialog']"));
        public IWebElement _lendingTextFE => driver.FindElement(By.XPath("//p[text()= 'Вільних місць у хвилі набору']"));
    }
}
