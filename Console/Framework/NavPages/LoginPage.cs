using OpenQA.Selenium;
using Framework.AutomationCore;

namespace Framework.NavPages
{
    public class LoginPage
    {
        public string Username = "harnold@123.com";
        public string Password = "Zaq12wsX";
        public string Testing1 = "https://int1-app.nav.com/login";

        public IWebElement FldUsername => WebDriver.FindElement(By.Id("session_email"));
        public IWebElement FldPassword => WebDriver.FindElement(By.Id("session_password"));
        public IWebElement BtnLogin => WebDriver.FindElement(By.Id("session_submit"));

        public void Login()
        {
            FldUsername.SendKeys(Username);
            FldPassword.SendKeys(Password);
            BtnLogin.Click();
        }
    }
}
