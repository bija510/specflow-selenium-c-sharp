using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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

    [Binding]
    public sealed class ScenarioOutlineSD
    {
        IWebDriver driver = null;
        [Given(@"the user is in fb login page")]
        public void GivenTheUserIsInFbLoginPage()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
        }

        [Then(@"the user input user Name (.*)")]
        public void ThenTheUserInputUserNameAdmin(String username)
        {
            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys(username);
        }

        [Then(@"the user input password (.*)")]
        public void ThenTheUserInputPasswordAdmin(String pwd)
        {
            driver.FindElement(By.XPath("//input[@id='pass']")).SendKeys(pwd);
        }

        [Then(@"the user close browser")]
        public void ThenTheUserCloseBrowser()
        {       
            Thread.Sleep(3000);
            driver.Quit();

        }



    }
}
