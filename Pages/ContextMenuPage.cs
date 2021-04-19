using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace HerokuAppTest
{
    internal class ContextMenuPage : BaseHerokuAppPage
    {
        public ContextMenuPage(IWebDriver driver) : base(driver) { }

        internal AlertBox ClickElement(IWebDriver driver)
        {
            Actions actions = new Actions(Driver);
            var alertWindow = Driver.FindElement(By.Id("hot-spot"));
            actions.ContextClick(alertWindow).Perform();
            IAlert alert = Driver.SwitchTo().Alert();
            String text = Driver.SwitchTo().Alert().Text;
            alert.Accept();
            return new AlertBox(Driver);
        }
    }
}