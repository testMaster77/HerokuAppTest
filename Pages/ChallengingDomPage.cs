using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;

namespace HerokuAppTest
{
    internal class ChallengingDomPage : BaseHerokuAppPage
    {
        public ChallengingDomPage(IWebDriver driver) : base(driver) { }

        internal TableText ReadTableCellText(IWebDriver driver)
        {
            String cellText5 = Driver.FindElement(By.XPath("/html//div[@id='content']/div[@class='example']//table//td[.='Iuvaret5']")).Text;
            Console.WriteLine("text5: " + cellText5);
            String cellText3 = Driver.FindElement(By.XPath("/html//div[@id='content']/div[@class='example']//table//td[.='Adipisci5']")).Text;
            Console.WriteLine("text3: " + cellText3);
            return new TableText(Driver);
        }
    }
}