using System.Reflection;
using OpenQA.Selenium;

namespace src.pages
{
    public class ParaBankHomePage
    {

        private IWebDriver driver;


        public ParaBankHomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // register link
        private By registerLinkLocator = By.CssSelector("div[id='loginPanel'] > p:nth-of-type(2) > a");

        public ParaBankHomePage clickRegisterLink()
        {
            IWebElement registerLink = driver.FindElement(registerLinkLocator);
            registerLink.Click();
            return this;
        }
    }
}
