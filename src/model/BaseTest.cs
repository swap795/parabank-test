using System.Reflection;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace src.model
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        protected virtual void BeforeEach()
        {
            driver = new ChromeDriver();
        }


        [TearDown]
        protected virtual void AfterEach()
        {
            driver.Quit();
        }

        protected static void GoTo(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}

