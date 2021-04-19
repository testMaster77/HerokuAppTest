using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace HerokuAppTest
{
    internal class DropDownPage : BaseHerokuAppPage
    {
        public bool IsVisible 
        {
            get
            {
                return Driver.FindElement(By.XPath("//option[contains(text(),'Option 2')]")).Displayed;
            }
            internal set { }
        }

        public DropDownPage(IWebDriver driver) : base(driver) { }

        internal DropDownPage SelectDropDownOption(IWebDriver driver)
        {
            SelectElement dropdownSelect = new SelectElement(driver.FindElement(By.Id("dropdown")));
            foreach (IWebElement element in dropdownSelect.Options)
            {
                if (element.Text == "Option 2")
                {
                    element.Click();
                }
            }
            return new DropDownPage(Driver);
        }
    }
}