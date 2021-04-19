using OpenQA.Selenium;
using System;

namespace HerokuAppTest
{
    internal class AddRemoveElementsPage : BaseHerokuAppPage
    {
        
        public IWebElement AddElementButton => Driver.FindElement(By.XPath("//button[contains(text(),'Add Element')]"));

        public AddRemoveElementsPage(IWebDriver driver) : base(driver) {}

        internal AddFiveElements ClickToAddFiveElements(IWebDriver driver)
        {
            for (int i = 0; i < 5; i++)
            {
                AddElementButton.Click();
            }
            return new AddFiveElements(Driver);
        }
    }
}