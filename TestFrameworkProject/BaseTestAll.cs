using NUnit.Framework;
using OpenQA.Selenium;
using System.Drawing.Imaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrameworkProject
{[TestFixture]
    class BaseTestAll
    {
        public static void takeScreenshot(string fileName, IWebDriver driver)
        {
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(
                "E:\\report\\" + fileName + ".jpeg", System.Drawing.Imaging.ImageFormat.Gif);
        }
    }
}
