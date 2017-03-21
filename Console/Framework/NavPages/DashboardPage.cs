using OpenQA.Selenium;
using Framework.AutomationCore;
using OpenQA.Selenium.Interactions;
using System;

namespace Framework.NavPages
{
    public class DashboardPage
    {

        public IWebElement MenuTools => WebDriver.FindElement(By.ClassName("c-dropdown-menu__title"));
        public IWebElement LnkTools => WebDriver.FindElement(By.LinkText("TOOLS"));
        public IWebElement BizLaunch => WebDriver.FindElement(By.LinkText("BusinessLauncher"));
        public void GoToBusinessLauncher()
        {
            WebDriver.Hover( MenuTools );
            LnkTools.Click();
        }
    }
}