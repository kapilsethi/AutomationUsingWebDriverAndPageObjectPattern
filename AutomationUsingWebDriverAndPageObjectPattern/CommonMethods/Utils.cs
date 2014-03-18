using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace AutomationUsingWebDriverAndPageObjectPattern.CommonMethods
{
    public class Utils
    {
        public static IWebElement GetParent(IWebElement webElement)
        {
            return webElement.FindElement(By.XPath(".."));
        }

        public static ReadOnlyCollection<IWebElement> GetChild(IWebElement webElement, string childElementType)
        {
            return webElement.FindElements(By.XPath(".//"+childElementType));
        }
    }
}
