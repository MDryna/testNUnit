using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testNUnit.Map;

namespace testNUnit.PageObject
{
    public class AuthorizationPageObject : BaseTest
    {
        private readonly BaseMap BaseMap = new BaseMap();
        
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        
        public void Login(string login, string password)
        {
            this.BaseMap.AuthorizationMap._loginInputEmail.SendKeys(login);
            this.BaseMap.AuthorizationMap._loginInputPassword.SendKeys(password);
     
            IWebElement submitLogIn = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BaseMap.AuthorizationMap._submitLogIn));
            submitLogIn.Click();
        }
        

        public void FailedLogin_CheckErrorDisplayed(string randomEmail, string randomPassword)
        {

            this.BaseMap.AuthorizationMap._loginInputEmail.SendKeys(randomEmail);
            this.BaseMap.AuthorizationMap._loginInputPassword.SendKeys(randomPassword);
            IWebElement submitLogIn = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BaseMap.AuthorizationMap._submitLogIn));
            submitLogIn.Click();



        }

        public bool CheckErrorDisplayed()
        {
            try
            {
                bool displayed = BaseMap.AuthorizationMap._errormessage.Displayed;
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }



    }
}
