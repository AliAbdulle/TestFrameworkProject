using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrameworkProject
{
    [TestFixture]
    public class ChromeTest
    {
        [Test]
        public void TestRecieveMail()
        {
            //Selenium code
            Console.WriteLine("Recieve mail");
        }
        [Test]
        public void SemdMail()
        {
            //selenium Code
            Console.WriteLine("Sending email mail");
        }

        [SetUp]
        public void setup()
        {
            Console.WriteLine("Set up");
        }
       
    }
}
