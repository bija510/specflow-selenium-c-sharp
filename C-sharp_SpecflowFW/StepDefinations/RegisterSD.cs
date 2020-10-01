using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace CsharpSpecflowFW.StepDefinations
{
    /**********************************************************************************************************
     * IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
     * IWebDriver driver = new FirefoxDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
     * IWebDriver driver = new InternetExplorerDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
     ***********************************************************************************************************/
    [Binding]
    public sealed class RegisterSD
    {
        IWebDriver driver = null;
        [Given(@"i lunch the application")]
        public void GivenILunchTheApplication()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            driver.Url = "http://demo.automationtesting.in/Register.html";            
        }

        [Given(@"i enter the first name")]
        public void GivenIEnterTheFirstName()
        {
            driver.FindElement(By.XPath("//input[@placeholder='First Name']")).SendKeys("Michal");
        }

        [Then(@"i enter the last name")]
        public void ThenIEnterTheLastName(Table table)
        {
            driver.FindElement(By.XPath("//input[@placeholder='Last Name']")).SendKeys("Black");
        }

        [Then(@"i click the register")]
        public void ThenIClickTheRegister()
        {
            driver.FindElement(By.XPath("//button[@id='submitbtn']")).Click();
            Thread.Sleep(3000);
            driver.Quit();
        }

    }
}
