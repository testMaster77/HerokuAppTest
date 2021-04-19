using OpenQA.Selenium;

namespace HerokuAppTest
{
    internal class MovedSlider
    {
        private IWebDriver Driver { get; set; }

        public MovedSlider(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}