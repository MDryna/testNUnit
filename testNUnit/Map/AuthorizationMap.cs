using OpenQA.Selenium;

namespace testNUnit.Map;

public class AuthorizationMap : BaseTest
{
    public IWebElement _loginInputEmail => driver.FindElement(By.CssSelector("[type='email']"));
    public  IWebElement _loginInputPassword => driver.FindElement(By.CssSelector("[type='password']"));
    public  IWebElement _submitLogIn => driver.FindElement(By.CssSelector("[type='submit']"));
    public  IWebElement _errormessage => driver.FindElement(By.CssSelector("[class='message-list']"));
  
}