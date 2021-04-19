using OpenQA.Selenium;

namespace HerokuAppTest
{
    internal class TableText
    {
        private IWebDriver Driver { get; set; }

        public TableText(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}