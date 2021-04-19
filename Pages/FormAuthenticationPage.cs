using OpenQA.Selenium;
using System;

namespace HerokuAppTest
{
    internal class FormAuthenticationPage : BaseHerokuAppPage
    {
        public IWebElement UserNameField => Driver.FindElement(By.Id("username"));

        public IWebElement PasswordField => Driver.FindElement(By.Id("password"));

        public IWebElement LoginButton => Driver.FindElement(By.XPath("//i[contains(text(),'Login')]"));

        public FormAuthenticationPage(IWebDriver driver) : base(driver) { }

        internal LoginPage FillOutFormAndSubmit(LoginUser user)
        {
            UserNameField.SendKeys(user.Username);
            PasswordField.SendKeys(user.Password);
            LoginButton.Click();
            return new LoginPage(Driver);
        }
    }
}