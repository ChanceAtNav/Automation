using Framework.AutomationCore;
using Framework.NavPages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1 : TestBase
    {
        [TestMethod]
        public void SetupTest()
        {
             Assert.IsTrue(WebDriver.GetTitle() == "nav");
        }
        [TestMethod]
        public void SecondTest()
        {
            Pages.Dashboard.GoToBusinessLauncher();
            Assert.IsTrue(WebDriver.IsElementFound(Pages.Dashboard.BizLaunch));
        }
        //[TestMethod]
        //public void BizLaunchTest()
        //{
        //    Pages.Dashboard.GoToBusinessLauncher();
        //    Pages.BusinessLauncher.PageLoadSuccessful();
        //    Assert.IsTrue(WebDriver.IsElementFound(Pages.BusinessLauncher.Goal));
        //}
        [TestMethod]
        public void ExperianPersonalTest()
        {
            Pages.Disputes.StartExperianPersonal();
        }
    }
}
