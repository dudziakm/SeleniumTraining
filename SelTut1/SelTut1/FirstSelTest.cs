using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelTut1
{

    class FirstSelTest
    {
        [Test]
        public void FirstTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://pl.wikipedia.org/");
            string welcome = driver.FindElement(By.Id("main-page-welcome")).Text;
            Assert.IsTrue(welcome.Contains("Witaj w"));
            driver.Quit();
        }
    }
}
