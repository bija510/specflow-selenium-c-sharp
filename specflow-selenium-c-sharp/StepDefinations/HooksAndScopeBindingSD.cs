using CsharpSpecflowFW.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using TechTalk.SpecFlow;

namespace CsharpSpecflowFW.StepDefinations
{
    [Binding]
    public sealed class HooksAndScopeBindingSD : BaseUtil
    {
       
        private BaseUtil bases;
	    public HooksAndScopeBindingSD(BaseUtil bases)
        {
            this.bases = bases;
        }

        [Scope(Tag ="test", Feature = "HooksFF")] //this will only soecefic to feature with tag test
        [Given(@"user is in Register page")]
        public void GivenUserIsInRegisterPage()
        {
            bases.driver.Url = "http://demo.automationtesting.in/Register.html";
            Assert.IsTrue(bases.driver.Title.ToLower().Contains("register"));
           
        }

        [Given(@"user enter first name")]
        public void GivenUserEnterFirstName()
        {
            var firstNameTxt = bases.driver.FindElement(By.XPath("//input[@placeholder='First Name']"));
            firstNameTxt.SendKeys("Robert");
        }

    }
}
