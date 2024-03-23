using System.Reflection;
using OpenQA.Selenium;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

using src.model;
using src.pages;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Safari;


namespace tests
{
    [TestFixture]
    public class RegisterTest : BaseTest
    {


        /**
            1. go to parabank.parasoft
            2. click on register
            3. assert that registration form is visible
            4. fill out the registration form
            5. click register
            6. assert that registration is done
        */


        public void openBrowser(string browserName)
        {
            switch (browserName)
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;

                case "firefox":
                    driver = new FirefoxDriver();
                    break;

                case "safari":
                    driver = new SafariDriver();
                    break;

                default:
                    break;
            }
        }


        //Name("Register an Account Test"), Description("Try clicking on the register link")
        [Test]
        public void registerAccountTest()
        {
            string URL = "https://parabank.parasoft.com/parabank/index.htm";


            // open specific browser
            // chrome
            // firefox
            // safari

            GoTo(driver, URL);

            HomePage homePage = new HomePage(driver);
            homePage.clickRegisterLink();

            Console.WriteLine("hello");
        }
    }
}
