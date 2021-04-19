using NLog;
using OpenQA.Selenium;
using System;

namespace HerokuAppTest
{
    internal class HerokuAppHomePage : BaseHerokuAppPage
    {
        //private static Logger _logger = LogManager.GetCurrentClassLogger();

        public HerokuAppHomePage(IWebDriver driver) : base(driver) { }

        public bool IsVisible { get; internal set; }
        public IWebElement AddRemoveElementsLink => Driver.FindElement(By.LinkText("Add/Remove Elements"));

        public IWebElement CheckBoxesLink => Driver.FindElement(By.LinkText("Checkboxes"));

        public IWebElement ContextMenuLink => Driver.FindElement(By.LinkText("Context Menu"));

        public IWebElement JavaScriptAlertLink => Driver.FindElement(By.LinkText("JavaScript Alerts"));

        public IWebElement HorizontalSliderLink => Driver.FindElement(By.LinkText("Horizontal Slider"));

        public IWebElement DynamicControlsLink => Driver.FindElement(By.LinkText("Dynamic Controls"));

        public IWebElement DropDownLink => Driver.FindElement(By.LinkText("Dropdown"));

        public IWebElement FormAuthenticationLink => Driver.FindElement(By.LinkText("Form Authentication"));

        public IWebElement ChallengingDomLink => Driver.FindElement(By.LinkText("Challenging DOM"));

        internal void GoTo()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");
        }

        internal AddRemoveElementsPage ClickAddRemoveLink(IWebDriver driver)
        {
            AddRemoveElementsLink.Click();
            //_logger.Info($"Add 5 elements=>{AddRemoveElementsLink}");
            return new AddRemoveElementsPage(Driver);
        }

        internal CheckBoxesPage ClickCheckBoxesLink(IWebDriver driver)
        {
            CheckBoxesLink.Click();
            return new CheckBoxesPage(Driver);
        }

        internal ContextMenuPage ClickContextMenuLink(IWebDriver driver)
        {
            ContextMenuLink.Click();
            return new ContextMenuPage(Driver);
        }

        internal JavaScriptAlertsPage ClickJavaScriptAlertsLink(IWebDriver driver)
        {
            JavaScriptAlertLink.Click();
            return new JavaScriptAlertsPage(Driver);
        }

        internal HorizntalSliderPage ClickHorizontalSliderLink(IWebDriver driver)
        {
            HorizontalSliderLink.Click();
            return new HorizntalSliderPage(Driver);
        }

        internal DynamicControlsPage ClickDynamicControlsLink(IWebDriver driver)
        {
            DynamicControlsLink.Click();
            return new DynamicControlsPage(Driver);
        }

        internal DropDownPage ClickDropDownLink(IWebDriver driver)
        {
            DropDownLink.Click();
            return new DropDownPage(Driver);
        }

        internal FormAuthenticationPage ClickFormAuthenticationLink(IWebDriver driver)
        {
            FormAuthenticationLink.Click();
            return new FormAuthenticationPage(Driver);
        }

        internal ChallengingDomPage ClickChallengingDomLink(IWebDriver driver)
        {
            ChallengingDomLink.Click();
            int iRowsCount = Driver.FindElements(By.XPath("//*[@id='content']/div/div/div/div[2]/table/tbody/tr")).Count;
            Console.WriteLine("rows: " + iRowsCount);
            int iColumnsCount = Driver.FindElements(By.XPath("//*[@id='content']/div/div/div/div[2]/table/thead/tr/th")).Count;
            Console.WriteLine("columns: " + iColumnsCount);
            return new ChallengingDomPage(Driver);
        }
    }
}