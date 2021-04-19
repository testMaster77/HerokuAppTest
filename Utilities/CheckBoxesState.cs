using OpenQA.Selenium;

namespace HerokuAppTest
{
    internal class CheckBoxesState
    {
        private IWebDriver driver;

        public CheckBoxesState(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}