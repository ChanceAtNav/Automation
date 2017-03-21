using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NavWeb
{
    [TestClass]
    public class UnitTest1
    {
        static IWebDriver driverff;
        static IWebDriver drivergc;

        [AssemblyInitialize]
        public static void SetUp(TestContext context)
        {
            driverff = new FirefoxDriver();
            drivergc = new ChromeDriver();
        }

        [TestMethod]
        public void TestFirefoxDriver()
        {
            driverff.Navigate().GoToUrl("https://nav.com");
            driverff.FindElement(By.XPath("//*[@id=\"primary - nav\"]/div[1]/a[1]"));
            
        }
    }
}
