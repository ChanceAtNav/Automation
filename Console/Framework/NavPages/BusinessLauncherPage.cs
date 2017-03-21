//using OpenQA.Selenium;
//using Framework.AutomationCore;

//namespace Framework.NavPages
//{
//    public class BusinessLauncherPage
//    {
//        public string Url => "https://int1-app.nav.com/app/build/business_launcher?ref=navbar";
//        public string Cv = "123";
//        public string CreditCardExp = "0119";
//        public string CreditCard = "411111111111";

//        // Add a business if no business is added elements
//        public IWebElement AddBiz => WebDriver.FindElement(By.LinkText("Add Your Business"));
//        public IWebElement BizName => WebDriver.FindElement(By.ClassName(""));
//        public IWebElement BizZip => WebDriver.FindElement(By.ClassName(""));
//        public IWebElement AddBizBtn => WebDriver.FindElement(By.ClassName(""));


//        public IWebElement Goal => WebDriver.FindElement(By.ClassName("goal-icon"));
//        public IWebElement Upgrade => WebDriver.FindElement(By.XPath('//*[@id="main-area"]/[2]//[4]/task-detail[1]/[2]/[1]'));
//        public IWebElement CcNumber => WebDriver.FindElement(By.ClassName("cc-number"));
//        public IWebElement CcExp => WebDriver.FindElement(By.ClassName("cc-expiration"));
//        public IWebElement CVC => WebDriver.FindElement(By.ClassName("cc-cvc"));
//        public IWebElement UpgradeSubmit => WebDriver.FindElement(By.ClassName("btn -round -secondary-1"));

//        public IWebElement placeholder1 => WebDriver.FindElement(By.ClassName(""));
//        public IWebElement placeholder2 => WebDriver.FindElement(By.ClassName(""));
//        public IWebElement placeholder3 => WebDriver.FindElement(By.ClassName(""));
//        public IWebElement placeholder4 => WebDriver.FindElement(By.ClassName(""));
//        public IWebElement placeholder5 => WebDriver.FindElement(By.ClassName(""));
//        public IWebElement placeholder6 => WebDriver.FindElement(By.ClassName(""));
//        public IWebElement placeholder7 => WebDriver.FindElement(By.ClassName(""));
//        public IWebElement placeholder8 => WebDriver.FindElement(By.ClassName(""));

//        public void PageLoadSuccessful()
//        {
//            if (WebDriver.GetUrl() != Url )
//            {
//                throw new System.Exception($"Unexpected page loaded:{WebDriver.GetUrl()}");
//            }
//        }

//        public void AddBusiness()
//        {
//            AddBiz.Click();
//            BizName.SendKeys("Apple");
//            BizZip.SendKeys("95014");
//            AddBizBtn.Click();
//        }

//        public void UpgradeToPremium()
//        {
//            Upgrade.Click();
//            CcNumber.SendKeys(CreditCard);
//            CcExp.SendKeys(CreditCardExp);
//            CVC.SendKeys(Cv);
//            UpgradeSubmit.Click();

//        }
//        public void BizLauncher()
//        {
            
//        }
//   }

//}
