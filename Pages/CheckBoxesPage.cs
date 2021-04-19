using OpenQA.Selenium;
using System;

namespace HerokuAppTest
{
    internal class CheckBoxesPage : BaseHerokuAppPage
    {
        public CheckBoxesPage(IWebDriver driver) : base(driver) { }
 
        internal CheckBoxesState VerifyCheckBoxesState(IWebDriver driver)
        {
            IWebElement checkBox = Driver.FindElement(By.XPath("//body/div[2]/div[1]/div[1]/form[1]/input[2]"));
            checkBox.Click();
            Boolean isSelected = checkBox.Selected;
            if (isSelected == false)
            {
                checkBox.Click();
            }
            IWebElement checkBox1 = Driver.FindElement(By.XPath("//body/div[2]/div[1]/div[1]/form[1]/input[1]"));
            checkBox1.Click();
            Boolean isSelected1 = checkBox1.Selected;
            if (isSelected1 == false)
            {
                checkBox1.Click();
            }
            return new CheckBoxesState(Driver);
        }
    }
}