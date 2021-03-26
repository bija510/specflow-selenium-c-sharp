using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
namespace CsharpSpecflowFW.StepDefinations
{
    [TestFixture]
    class zTemp
    {
        [Test]
        public void test()
        {
            Console.WriteLine(new zTemp2().config());
           



            //var data = new Dictionary<string, string>();
            //foreach (var row in File.ReadAllLines(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..")) + "\\StepDefinations\\zConfig.ini"))
            //    data.Add(row.Split('=')[0], string.Join("=", row.Split('=').Skip(1).ToArray()));

            //Console.WriteLine(data["ServerName"]);
            //Console.WriteLine(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,@"msedgedriver.exe")));

            //IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            //driver.Url = "https://www.facebook.com/";
            //OpenQA.Selenium.ITakesScreenshot ts = driver as ITakesScreenshot;
            //Screenshot screenshot = ts.GetScreenshot();
            //screenshot.SaveAsFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..")) + "\\Screenshot\\" + "methodName" + ".png", ScreenshotImageFormat.Png);
            //driver.Close();

        }
    }
}
