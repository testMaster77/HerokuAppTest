using OpenQA.Selenium;

namespace HerokuAppTest
{
    internal class LoginPage : BaseHerokuAppPage
    {
        public bool IsVisible 
        {
            get
            {
                return Driver.FindElement(By.CssSelector("#flash")).Displayed;
            }
            internal set { }
        }

        public LoginPage(IWebDriver driver) : base(driver) { }
    }
}