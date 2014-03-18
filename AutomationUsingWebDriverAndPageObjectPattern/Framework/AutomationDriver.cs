using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace AutomationUsingWebDriverAndPageObjectPattern.FrameWork
{
    public class AutomationDriver
    {
        private IWebDriver webDriver = new FirefoxDriver(); 

        public IWebDriver OurAutomationDriver()
        {
            return webDriver;
        }
    }
}
