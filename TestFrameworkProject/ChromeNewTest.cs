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
    //[Ignore("Skip test")]
    class ChromeNewTest
    {
        [Test]
        public void testNews()
        {
            Console.WriteLine("Test News");

            //selenium code
            //expected , actual
            //test is present
            //link is present

            //Assert.AreEqual("Good", "Good");
            Console.WriteLine("Before assertation error");

            try
            {
                Assert.IsTrue(4 > 2, "error msg");
                //Assert.IsFalse(2 > 5, "error mesg");
            }catch(Exception e)
            {
                Console.WriteLine("Cought th error");
            }

            Console.WriteLine(" Aftere assertation error");

        }
    }
}
