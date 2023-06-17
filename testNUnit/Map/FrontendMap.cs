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
        public IWebElement _titleOnFrontendPage => driver.FindElement(By.XPath("//h1[@class='typography_landingRegularH1__MbmS4 CourseHeroSection_title__R804k']"));
        public IWebElement _alertOnFrontendPage => driver.FindElement(By.XPath("//div[@class='ReactModal__Overlay ReactModal__Overlay--after-open Modal_maModalOverlay__GI9aM']"));
        public IWebElement _lendingTextFE => driver.FindElement(By.XPath("//p[text()= 'Вільних місць у хвилі набору']"));
    }
}
