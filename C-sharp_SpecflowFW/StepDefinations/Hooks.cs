using CsharpSpecflowFW.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
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
    [Binding]
    public sealed class Hooks : BaseUtil
    {
        private BaseUtil bases;

        public Hooks(BaseUtil bases)
        {
            this.bases = bases;
        }

        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        
        [BeforeScenario]
        public void BeforeScenario()
        {
            string browserName = new Configuration.configFile().browserName();
            
            if (browserName.Equals("CHROME"))
            {
                bases.driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                bases.driver.Manage().Window.Maximize();
            }
            else if (browserName.Equals("FIREFOX"))
            {
                bases.driver = new FirefoxDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                bases.driver.Manage().Window.Maximize();
            }
            else if (browserName.Equals("IE"))
            {
                bases.driver = new InternetExplorerDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                bases.driver.Manage().Window.Maximize();
            }
        }

        [AfterScenario]
        public void AfterScenario()
        {
            // inc. class name
            //var fullNameOfTheMethod = NUnit.Framework.TestContext.CurrentContext.Test.FullName;
            //Console.WriteLine("===========>" + fullNameOfTheMethod);//C_Sharp_Selenium_NUnit.Test_Cases.TearDown_ScreenShot.TestMethod

            // method name only
            var methodName = NUnit.Framework.TestContext.CurrentContext.Test.Name;
            Console.WriteLine("===========>" + methodName); //TestMethod

            // the state of the test execution
            var state = NUnit.Framework.TestContext.CurrentContext.Result.Outcome; // TestState enum
            Console.WriteLine("===========>" + state.ToString()); // 1. (Failed:Error) 2. (Passed)

            if (!(state.ToString() == "Passed"))
            {
                OpenQA.Selenium.ITakesScreenshot ts = bases.driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..")) + "\\Screenshot\\" + methodName + ".png", ScreenshotImageFormat.Png); //this path is different than other FW
                Console.WriteLine("====Screenshot Taken Successfully====");
            }

            Thread.Sleep(2000);
            bases.driver.Quit();
            bases.driver = null;
        }
    }
}
