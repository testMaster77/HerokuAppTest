using OpenQA.Selenium;

namespace HerokuAppTest
{
    internal class EnterText
    {
        private IWebDriver Driver { get; set; }
        public bool IsVisible 
        {
            get
            {
                return Driver.FindElement(By.CssSelector("#message")).Displayed;
            }
            internal set { }
        }

        public EnterText(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}