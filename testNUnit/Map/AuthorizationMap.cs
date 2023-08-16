using OpenQA.Selenium;

namespace testNUnit.Map;

public class AuthorizationMap : BaseTest
{
    public IWebElement _loginContainer => driver.FindElement(By.ClassName("FormStyleContainer_formWrapper__Kj3JV"));
        public IWebElement _loginInputEmail => _loginContainer.FindElement(By.CssSelector("[type='email']"));
        public  IWebElement _loginInputPassword => _loginContainer.FindElement(By.CssSelector("[type='password']"));
        public  IWebElement _submitLogIn => _loginContainer.FindElement(By.CssSelector("[type='submit']"));
    public  IWebElement _errormessage => driver.FindElement(By.ClassName("message-list"));
  
}