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

        //Name("Register an Account Test"), Description("Try clicking on the register link")
        [Test]
        public void registerAccountTest()
        {
            string URL = "https://parabank.parasoft.com/parabank/index.htm";

            GoTo(driver, URL);

            ParaBankHomePage parabankHomePage = new ParaBankHomePage(driver);
            parabankHomePage.clickRegisterLink();

            Console.WriteLine("hello");
        }
    }
}
