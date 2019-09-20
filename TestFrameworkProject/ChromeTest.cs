using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrameworkProject
{
    [TestFixture]
    [Parallelizable]
    public class ChromeTest
    {
        [Test]
        public void TestRecieveMail()
        {
            //Selenium code
            Console.WriteLine("Recieve mail");
        }
        [Test]
        public void SendMail()
        {
            //selenium Code
            Console.WriteLine("Sending email mail");
        }

        [SetUp]
        public void openBrowser()
        {
            Console.WriteLine("Open Browser");
        }

        [TearDown]
        public void loseBrowser()
        {
            Console.WriteLine("Close Browser");
        }

    }
}
