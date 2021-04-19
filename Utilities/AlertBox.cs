using OpenQA.Selenium;

namespace HerokuAppTest
{
    internal class AlertBox
    {
        private IWebDriver driver;

        public AlertBox(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}