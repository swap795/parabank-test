using System.Reflection;
using OpenQA.Selenium;

namespace src.pages
{
    public class HomePage
    {

        private IWebDriver driver;


        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // register link
        private By registerLinkLocator = By.CssSelector("div[id='loginPanel'] > p:nth-of-type(2) > a");

        public HomePage clickRegisterLink()
        {
            IWebElement registerLink = driver.FindElement(registerLinkLocator);
            registerLink.Click();
            return this;
        }


        public HomePage openBrowser()
        {
            return this;
        }

    }
}
