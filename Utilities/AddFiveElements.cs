using OpenQA.Selenium;

namespace HerokuAppTest
{
    internal class AddFiveElements
    {
        private IWebDriver Driver { get; set; }

        public AddFiveElements(IWebDriver driver)
        {
            Driver = driver;
        }

        public bool IsVisible
        {
            get
            {
                return Driver.FindElement(By.XPath("//body/div[2]/div[1]/div[1]/div[1]/button[5]")).Displayed;
            }
            internal set { }
        }
    }
}