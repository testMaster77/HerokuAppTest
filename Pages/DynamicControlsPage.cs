using OpenQA.Selenium;
using System;
using System.Threading;

namespace HerokuAppTest
{
    internal class DynamicControlsPage : BaseHerokuAppPage
    {
        public IWebElement EnableButton => Driver.FindElement(By.CssSelector("div.row:nth-child(2) div.large-12.columns:nth-child(2) div.example:nth-child(3) form:nth-child(10) > button:nth-child(2)"));

        public IWebElement EnterTextField => Driver.FindElement(By.XPath("//form[@id='input-example']/input[@type='text']"));

        public DynamicControlsPage(IWebDriver driver) : base(driver) { }

        internal EnterText EnableTextEnter(string v)
        {
            EnableButton.Click();
            Thread.Sleep(5000);
            EnterTextField.SendKeys("Text");
            return new EnterText(Driver);
        }
    }
}