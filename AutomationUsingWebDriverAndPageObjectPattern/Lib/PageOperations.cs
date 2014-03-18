using System;
using System.Threading;
using OpenQA.Selenium;
using AutomationUsingWebDriverAndPageObjectPattern.FrameWork;
using AutomationUsingWebDriverAndPageObjectPattern.CommonMethods;
using OpenQA.Selenium.Support.UI;

namespace AutomationUsingWebDriverAndPageObjectPattern.Lib
{
    public class PageOperations
    {
        private static IWebDriver driver = new AutomationDriver().OurAutomationDriver();

        public void OpenWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }
        
        public void WaitForPageLoad(string identifier)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(60000000));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id(identifier)));
        }
        
        public void Type(string identifier, string value)
        {
            driver.FindElement(By.Id(identifier)).SendKeys(value);
        }

        public void Click(string identifier)
        {
            driver.FindElement(By.Id(identifier)).Click();
        }

        public void ClickLink(string linkText)
        {
            driver.FindElement(By.LinkText(linkText)).Click();
        }

        public void SelectRadioButton(string identifier, string optionToBeSelected)
        {
            var webElements = driver.FindElements(By.CssSelector("input[type='radio'][name='"+identifier+"']"));
            foreach (IWebElement webElement in webElements)
            {
                if (Utils.GetParent(webElement).Text.ToLower() == optionToBeSelected.ToLower())
                {
                    webElement.Click();
                    break;
                }
            }
        }

        public void Select(string identifier, string optionToBeSelected)
        {
            IWebElement listElement = driver.FindElement(By.Id(identifier));
            listElement.Click();
            Thread.Sleep(1000);
            var options = Utils.GetChild(listElement, "li");
            foreach (var option in options)
            {
                if (option.Text.Contains(optionToBeSelected))
                {
                    option.Click();
                    break;
                }
            }
        }
    }
}
