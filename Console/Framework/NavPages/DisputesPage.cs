using OpenQA.Selenium;
using Framework.AutomationCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Framework.NavPages
{
    public class DisputesPage
    {
        public string Url => "https://int1-app.nav.com/app/build/credit_sweeper?ref=navbar";
        public IWebElement ExperianGetStarted => WebDriver.FindElement(By.ClassName("btn -secondary-7"));
        public IWebElement ExperianIdentity => WebDriver.FindElement(By.ClassName("modal-title"));
        public IWebElement ExpLooksGood => WebDriver.FindElement(By.ClassName("sweeper__button"));
        public IWebElement ExpCloseWnd => WebDriver.FindElement(By.ClassName("verify__button__close-window"));
        public IWebElement ExpVerified => WebDriver.FindElement(By.ClassName("fa-check"));



        public void PageLoadSuccessful()
        {
            if (WebDriver.GetUrl() != Url)
            {
                throw new System.Exception($"Unexpected page loaded:{WebDriver.GetUrl()}");
            }
        }

        public void StartExperianPersonal()
        {
            ExperianGetStarted.Click();
            Assert.IsTrue(WebDriver.IsElementFound(ExperianIdentity));
            ExpLooksGood.Click();
            ExpCloseWnd.Click();
            Assert.IsTrue(WebDriver.IsElementFound(ExpVerified));
        }

    }
}
