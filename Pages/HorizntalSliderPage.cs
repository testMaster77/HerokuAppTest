using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace HerokuAppTest
{
    internal class HorizntalSliderPage : BaseHerokuAppPage
    {
        public HorizntalSliderPage(IWebDriver driver) : base(driver) { }

        internal MovedSlider MoveSlider(IWebDriver driver)
        {
            IWebElement slider = Driver.FindElement(By.XPath("//body/div[2]/div[1]/div[1]/div[1]/input[1]"));
            Actions actions = new Actions(Driver);
            actions.Click(slider).Build().Perform();
            Thread.Sleep(1000);
            for (int i = 0; i < 2; i++)
            {
                actions.SendKeys(Keys.ArrowRight).Build().Perform();
            }
            return new MovedSlider(Driver);
        }
    }
}