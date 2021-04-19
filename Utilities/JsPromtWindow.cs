using OpenQA.Selenium;

namespace HerokuAppTest
{
    internal class JsPromtWindow
    {
        private IWebDriver Driver { get; set; }

        public JsPromtWindow(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}