using OpenQA.Selenium;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Lab5_SeleniumWebDriver
{
    [TestFixture]
    class Test
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

        }

        [TearDown]
        public void cleanup()
        {
            driver.Quit();
        }

        [Test]
        public void SearchWithoutValidData()
        {
            try
            {
                driver.Navigate().GoToUrl("https://www.kinopoisk.ru/");
                IWebElement dest = driver.FindElement(By.ClassName("kinopoisk-header-search-form-input__input"));
                dest.Click();
                dest.Clear();   
                dest.SendKeys("TestStringTestStringTestStringTestStringTestString");
                Thread.Sleep(5000);
                IWebElement searchForm = driver.FindElement(By.ClassName("kinopoisk-header-search-form-input__submit"));
                searchForm.Click();
                Thread.Sleep(5000);
            }
            catch (Exception e)
            {
                driver.Close();
                Console.WriteLine(e.Message);
            }
        }

        [Test]
        public void Registration()
        {
            try
            {
                driver.Navigate().GoToUrl("https://www.kinopoisk.ru/");
                IWebElement enter = driver.FindElement(By.ClassName("header-fresh-user-partial-component__login-button"));
                enter.Click();
                IWebElement email = driver.FindElement(By.Id("check_email"));
                email.Click();
                email.Clear();
                email.SendKeys("testik3@gmail.com");
                IWebElement next = driver.FindElement(By.Id("login_email_submit"));
                next.Click();

                IWebElement register_password = driver.FindElement(By.Id("register_password"));
                register_password.Click();
                register_password.Clear();
                register_password.SendKeys("123123123");

                IWebElement register_email_submit = driver.FindElement(By.Id("register_email_submit"));
                register_email_submit.Click();
                Thread.Sleep(5000);
            }
            catch (Exception e)
            {
                driver.Close();
                Console.WriteLine(e.Message);
            }
        }
    }
}