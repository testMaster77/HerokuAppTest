using OpenQA.Selenium;

namespace HerokuAppTest
{
    internal class BaseHerokuAppPage
    {
        protected IWebDriver Driver { get; set; }

        public BaseHerokuAppPage(IWebDriver driver)
        {
            Driver = driver;
            Driver.Manage().Window.Maximize();
        }
    }
}