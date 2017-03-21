using Framework.AutomationCore;
using Framework.NavPages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Tests
{
    public class TestBase
    {
        Pages Pages;
        [TestInitialize]
        public void Initialize()
        {
            // Anything in here will be done before every TestMethod
            WebDriver.InitializeBrowser(Browsers.Chrome);
            Pages = new Pages();
            //login 'method'
            WebDriver.NavigateTo(Pages.Login.Testing1);
            Pages.Login.Login();
        }
        [TestCleanup]
        public void Cleanup()
        {
            WebDriver.CloseBrowser();
        }
    }
}

