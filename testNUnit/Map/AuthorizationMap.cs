using OpenQA.Selenium;

namespace testNUnit.Map;

public class AuthorizationMap : BaseTest
{
    public IWebElement _loginInputEmail => driver.FindElement(By.CssSelector("input[type='email']"));
    public  IWebElement _loginInputPassword => driver.FindElement(By.XPath("//input[@type='password']"));
    public  IWebElement _submitLogIn => driver.FindElement(By.XPath("//button[@type='submit']"));
    public  IWebElement _errormessage => driver.FindElement(By.XPath("//div[@class='message-list']"));
  
}