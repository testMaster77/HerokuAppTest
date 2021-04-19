using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace HerokuAppTest
{
    internal class JavaScriptAlertsPage : BaseHerokuAppPage
    {
        public IWebElement JSPromtButton => Driver.FindElement(By.XPath("//button[contains(text(),'Click for JS Prompt')]"));

        public JavaScriptAlertsPage(IWebDriver driver) : base(driver) { }

        internal JsPromtWindow VerifyJSPromtFunctionality(IWebDriver driver)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", JSPromtButton);
            IAlert promptAlert = driver.SwitchTo().Alert();
            String alertText = promptAlert.Text;
            promptAlert.SendKeys("Test");
            Thread.Sleep(4000);
            promptAlert.Accept();
            return new JsPromtWindow(Driver);
        }
    }
}