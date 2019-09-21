using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrameworkProject
{
    [TestFixture]
    class TestClassA
    {

        [Test]
        public void testMethod()
        {
            ExtentReports extent = new ExtentReports("E:\\report\\report.html");
            var test =  extent.StartTest("TestClass A", "Simple Description");

            test.Log(LogStatus.Info, "Validating the download link");

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.wseleniumhq.org/";
            driver.Manage().Window.Maximize();

            IWebElement linkText = driver.FindElement(By.LinkText("Download"));
            linkText.Click();

            extent.EndTest(test);
            extent.Flush();

            driver.Quit();
        
        }
    }
}
