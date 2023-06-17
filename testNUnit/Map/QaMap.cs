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
        public IWebElement _lendingTextQA => driver.FindElement(By.XPath("//p[text()= 'Вільних місць у хвилі набору']"));
       
    }
}
