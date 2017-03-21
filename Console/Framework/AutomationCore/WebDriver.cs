using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace Framework.AutomationCore
{
    public class WebDriver
    {
        public static IWebDriver Driver;

        public static void InitializeBrowser( Browsers browserName )
        {
            switch ( browserName )
            {
                case Browsers.Chrome:
                    Driver = new ChromeDriver();
                    break;

                case Browsers.Firefox:
                    Driver = new FirefoxDriver();
                    break;
            }
        }

        public static void Hover(IWebElement element)
        {
            Actions action = new Actions(Driver);
            action.MoveToElement(element).Perform();
        }

        public static void NavigateTo( string url )
        {
            Driver.Url = url;
        }

        public static IWebElement FindElement(By by)
        {
            return Driver.FindElement( by );
        }

        public static string GetTitle()
        {
            return Driver.Title;
        }
        public static string GetUrl()
        {
            return Driver.Url;
        }
        public static void CloseBrowser()
        {
            Driver.Dispose();
            Driver.Quit();
        }
        public static bool IsElementFound( IWebElement element)
        {
            if (element.Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
