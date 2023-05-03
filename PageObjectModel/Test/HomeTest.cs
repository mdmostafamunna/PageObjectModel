using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectModel.Source.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace PageObjectModel.Test
{
    public class HomeTest
    {

        private IWebDriver _driver;

        [SetUp]
        public void InitScript()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();

        }



        [Test]
        public void SearchBook()
        {
            HomePage hp = new HomePage(_driver);
            _driver.Navigate().GoToUrl("https://www.amazon.com/");
            hp.Search("Selenium book");
            Assert.True(_driver.Title.Contains("Selenium book"));
        }

        [TearDown]
        public void Clearup()
        {
            _driver.Quit();
        }
    }
}
