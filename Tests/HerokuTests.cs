using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace HerokuAppTest
{
    [TestClass]
    [TestCategory("HerokuTests")]
    public class HerokuTests
    {
        private IWebDriver Driver { get; set; }

        [TestMethod]
        [Description("Add five elements by clicking a button")]
        [TestProperty("Author","VladimirSimsic")]
        public void AddFiveElementsTest()
        {
            Driver = GetChromeDriver();
            var herokuAppHomePage = new HerokuAppHomePage(Driver);
            herokuAppHomePage.GoTo();

            var addRemoveElementsPage = herokuAppHomePage.ClickAddRemoveLink(Driver);
            var addFiveElements = addRemoveElementsPage.ClickToAddFiveElements(Driver);
            Assert.IsTrue(addFiveElements.IsVisible);
        }
        [TestMethod]
        [Description("Verify state of the checkboxes")]
        [TestProperty("Author", "VladimirSimsic")]
        public void CheckBoxesTest()
        {
            Driver = GetChromeDriver();
            var herokuAppHomePage = new HerokuAppHomePage(Driver);
            herokuAppHomePage.GoTo();

            var checkBoxesPage = herokuAppHomePage.ClickCheckBoxesLink(Driver);
            var checkBoxesState = checkBoxesPage.VerifyCheckBoxesState(Driver);
        }
        [TestMethod]
        [Description("Verify appereance of alert and read alert text")]
        [TestProperty("Author", "VladimirSimsic")]
        public void ContextMenuTest()
        {
            Driver = GetChromeDriver();
            var herokuAppHomePage = new HerokuAppHomePage(Driver);
            herokuAppHomePage.GoTo();

            var contextMenuPage = herokuAppHomePage.ClickContextMenuLink(Driver);
            var alertBox = contextMenuPage.ClickElement(Driver);
        }
        [TestMethod]
        [Description("Verify functionality of JS prompts")]
        [TestProperty("Author", "VladimirSimsic")]
        public void JavaScriptAlertsTest()
        {
            Driver = GetChromeDriver();
            var herokuAppHomePage = new HerokuAppHomePage(Driver);
            herokuAppHomePage.GoTo();

            var javaScriptAlertsPage = herokuAppHomePage.ClickJavaScriptAlertsLink(Driver);
            var jsPromtWindow = javaScriptAlertsPage.VerifyJSPromtFunctionality(Driver);
        }
        [TestMethod]
        [Description("Set value 3.5 on slider and verify")]
        [TestProperty("Author", "VladimirSimsic")]
        public void HoruzontalSliderTest()
        {
            Driver = GetChromeDriver();
            var herokuAppHomePage = new HerokuAppHomePage(Driver);
            herokuAppHomePage.GoTo();

            var horizntalSliderPage = herokuAppHomePage.ClickHorizontalSliderLink(Driver);
            var movedSlider = horizntalSliderPage.MoveSlider(Driver);
        }
        [TestMethod]
        [Description("Enter 'Text' into textbox on page")]
        [TestProperty("Author", "VladimirSimsic")]
        public void DynamicControlsTest()
        {
            Driver = GetChromeDriver();
            var herokuAppHomePage = new HerokuAppHomePage(Driver);
            herokuAppHomePage.GoTo();

            var dynamicControlsPage = herokuAppHomePage.ClickDynamicControlsLink(Driver);
            var enterText = dynamicControlsPage.EnableTextEnter("Example text");
            Assert.IsTrue(enterText.IsVisible);
        }
        [TestMethod]
        [Description("Select option 2 in dropdown control")]
        [TestProperty("Author", "VladimirSimsic")]
        public void DropDownTest()
        {
            Driver = GetChromeDriver();
            var herokuAppHomePage = new HerokuAppHomePage(Driver);
            herokuAppHomePage.GoTo();

            var dropDownPage = herokuAppHomePage.ClickDropDownLink(Driver);
            var dropDown = dropDownPage.SelectDropDownOption(Driver);
            Assert.IsTrue(dropDown.IsVisible);
        }
        [TestMethod]
        [Description("Verify functionality of login form")]
        [TestProperty("Author", "VladimirSimsic")]
        public void FormAuthenticationTest()
        {
            Driver = GetChromeDriver();

            var loginUser = new LoginUser();
            loginUser.Username = "tomsmith";
            loginUser.Password = "SuperSecretPassword!";

            var herokuAppHomePage = new HerokuAppHomePage(Driver);
            herokuAppHomePage.GoTo();

            var formAuthenticationPage = herokuAppHomePage.ClickFormAuthenticationLink(Driver);
            var loginPage = formAuthenticationPage.FillOutFormAndSubmit(loginUser);
            Assert.IsTrue(loginPage.IsVisible);
        }

        [TestMethod]
        [Description("Count rows and columns in table and read text from cell 5, 3")]
        [TestProperty("Author", "VladimirSimsic")]
        public void ChallengingDomTest()
        {
            Driver = GetChromeDriver();
            var herokuAppHomePage = new HerokuAppHomePage(Driver);
            herokuAppHomePage.GoTo();

            var challengingDomPage = herokuAppHomePage.ClickChallengingDomLink(Driver);
            var tableText = challengingDomPage.ReadTableCellText(Driver);
        }

        [TestCleanup]
        public void CleanUpAfterEveryTestMethod()
        {
            //Driver.Close();
            //Driver.Quit();
        }

        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }
    }
}
